using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BF3SnipingComputer
{
    public partial class Form1 : Form
    {
        private int milMultiplier;
        private List<Weapon> weaponList;
        private List<Sight> sightList;
        private Weapon currentWeapon;
        private Sight currentSight;

        private BindingSource sightsBS;
        private BindingList<string> sightsFileList;
        private BindingSource weaponsBS;
        private BindingList<string> weaponsFileList;
        private BindingSource barrelsBS;
        private BindingList<string> barrelTypes;

        public Form1()
        {
            InitializeComponent();
            milMultiplier = 1000;
            weaponList = new List<Weapon>();
            sightList = new List<Sight>();

            sightsFileList = new BindingList<string>();
            sightsBS = new BindingSource();
            sightsBS.DataSource = sightsFileList;
            sightComboBox.DataSource = sightsBS;

            weaponsFileList = new BindingList<string>();
            weaponsBS = new BindingSource();
            weaponsBS.DataSource = weaponsFileList;
            weaponComboBox.DataSource = weaponsBS;

            barrelTypes = new BindingList<string>();
            barrelsBS = new BindingSource();
            barrelsBS.DataSource = barrelTypes;
            barrelTypeComboBox.DataSource = barrelsBS;

            loadWeaponsAndSights();

            setCurrentSight();
            setCurrentWeapon();
        }

        private float calculateSize(float mil, float d)
        {
            return (d * mil * currentSight.origMil) / milMultiplier;
        }

        private float calculateMils(float s, float d)
        {
            return (s * milMultiplier) / (d * currentSight.origMil);
        }

        private float calculateDistance(float mil, float s)
        {
            return (s * milMultiplier) / (mil * currentSight.origMil);
        }

        private float MiltoLines(float mil)
        {
            float part1 = (float)Math.Sqrt((currentSight.b * currentSight.b) - (4 * currentSight.a * currentSight.c));
            float xInt1 = (-(currentSight.b) + part1) / (2 * currentSight.a);
            float xInt2 = (-(currentSight.b) - part1) / (2 * currentSight.a);

            if (xInt1 < xInt2) return xInt1;
            else return xInt2;
        }

        private float LinesToMil(float lines)
        {
            return (currentSight.a * (lines * lines)) + (currentSight.b * lines) + currentSight.c;
        }

        private void displayDrop(float distance)
        {
            float velocity = getWeaponVelocity();

            float timeToTarget = (distance / velocity);
            if (timeToTarget < currentWeapon.timeToLive)
                timeToTargetOutput.Text = timeToTarget.ToString("F2") + " seconds";
            else
                timeToTargetOutput.Text = "Time to Target greater than Bullet Life Time";

            float drop = (currentWeapon.gravity * (distance * distance)) / (2 * (velocity * velocity));

            mDropOutput.Text = drop.ToString("F2");
            milDropOutput.Text = calculateMils(drop, distance).ToString("F2");
        }

        private void displayMaxRangeAndVelocity()
        {
            velocityOutputLabel.Text = getWeaponVelocity().ToString() + " m/s";
            maxRangeOutput.Text = (currentWeapon.timeToLive * getWeaponVelocity()).ToString("F0") + "m";
        }

        private int getWeaponVelocity()
        {
            if ((string)barrelTypeComboBox.SelectedItem == "None")
                return currentWeapon.velocity;
            else if ((string)barrelTypeComboBox.SelectedItem == "Suppressor")
                return currentWeapon.sVelocity;
            else if ((string)barrelTypeComboBox.SelectedItem == "Heavy Barrel")
                return currentWeapon.hbVelocity;
            else
                return 0;
        }

        private void calculateSizeButton_Click(object sender, EventArgs e)
        {
            float mils = 0.0f;
            if (!float.TryParse(milsTextBox.Text, out mils))
            {
                milsTextBox.Text = "Invalid Data in Mils Box";
                return;
            }

            float distance = 0.0f;
            if (!float.TryParse(distanceTextBox.Text, out distance))
            {
                distanceTextBox.Text = "Invalid Data in Distance Box";
                return;
            }

            targetSizeTextBox.Text = calculateSize(mils, distance).ToString("F2");

            displayDrop(distance);
        }

        private void calculateMilButton_Click(object sender, EventArgs e)
        {
            float distance = 0.0f;
            if (!float.TryParse(distanceTextBox.Text, out distance))
            {
                distanceTextBox.Text = "Invalid Data in Distance Box";
                return;
            }

            float size = 0.0f;
            if (!float.TryParse(targetSizeTextBox.Text, out size))
            {
                targetSizeTextBox.Text = "Invalid Data in Target Size Box";
                return;
            }

            milsTextBox.Text = calculateMils(size, distance).ToString("F2");

            displayDrop(distance);
        }

        private void calculateDistanceButton_Click(object sender, EventArgs e)
        {
            float mils = 0.0f;
            if (!float.TryParse(milsTextBox.Text, out mils))
            {
                milsTextBox.Text = "Invalid Data in Mils Box";
                return;
            }

            float size = 0.0f;
            if (!float.TryParse(targetSizeTextBox.Text, out size))
            {
                targetSizeTextBox.Text = "Invalid Data in Target Size Box";
                return;
            }

            float distance = calculateDistance(mils, size);

            distanceTextBox.Text = distance.ToString("F2");

            displayDrop(distance);
        }

        private void distanceTextBox_TextChanged(object sender, EventArgs e)
        {
            float distance;
            if (!float.TryParse(distanceTextBox.Text, out distance))
            {
                return;
            }

            displayDrop(distance);
        }

        private void loadWeaponsAndSights()
        {
            string line;
            StreamReader sightsFile = new StreamReader("Sights.txt");
            while ((line = sightsFile.ReadLine()) != null)
            {
                sightsFileList.Add(line);
            }
            sightsFile.Close();

            foreach (String s in sightsFileList)
            {
                Sight newSight = new Sight();
                StreamReader sFile = new StreamReader("Sights/" + s + ".txt");
                int lineNumber = 0;
                while ((line = sFile.ReadLine()) != null)
                {
                    lineNumber++;
                    if (lineNumber == 1)
                        float.TryParse(line.Substring(7), out newSight.origMil);

                    else if (lineNumber == 2)
                        int.TryParse(line.Substring(7), out newSight.origPixels);

                    else if (lineNumber == 3)
                        float.TryParse(line.Substring(2), out newSight.a);

                    else if (lineNumber == 4)
                        float.TryParse(line.Substring(2), out newSight.b);

                    else if (lineNumber == 5)
                        float.TryParse(line.Substring(2), out newSight.c);
                }
                newSight.name = s;
                sightList.Add(newSight);
                sFile.Close();
            }

            StreamReader weaponsFile = new StreamReader("Weapons.txt");
            while ((line = weaponsFile.ReadLine()) != null)
            {
                weaponsFileList.Add(line);
            }
            weaponsFile.Close();

            foreach (String s in weaponsFileList)
            {
                Weapon newWeapon = new Weapon();
                StreamReader wFile = new StreamReader("Weapons/" + s + ".txt");
                int lineNumber = 0;
                while ((line = wFile.ReadLine()) != null)
                {
                    lineNumber++;

                    if (lineNumber == 1)
                        int.TryParse(line.Substring(9), out newWeapon.velocity);
                    else if (lineNumber == 2)
                        int.TryParse(line.Substring(10), out newWeapon.sVelocity);
                    else if (lineNumber == 3)
                        int.TryParse(line.Substring(11), out newWeapon.hbVelocity);
                    else if (lineNumber == 4)
                        float.TryParse(line.Substring(8), out newWeapon.gravity);
                    else if (lineNumber == 5)
                        float.TryParse(line.Substring(11), out newWeapon.timeToLive);

                }
                newWeapon.name = s;
                weaponList.Add(newWeapon);
                wFile.Close();
            }
        }

        private void sightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentSight();
        }

        private void setCurrentSight()
        {
            foreach (Sight s in sightList)
            {
                if (s.name == sightsFileList[sightComboBox.SelectedIndex])
                {
                    currentSight = s;
                    break;
                }
            }
        }

        private void weaponComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCurrentWeapon();
        }

        private void setCurrentWeapon()
        {
            foreach (Weapon w in weaponList)
            {
                if (w.name == weaponsFileList[weaponComboBox.SelectedIndex])
                {
                    currentWeapon = w;
                    break;
                }
            }

            barrelTypes.Clear();
            if (currentWeapon.velocity != 0)
                barrelTypes.Add("None");
            if (currentWeapon.sVelocity != 0)
                barrelTypes.Add("Suppressor");
            if (currentWeapon.hbVelocity != 0)
                barrelTypes.Add("Heavy Barrel");
            barrelTypeComboBox.DataSource = barrelTypes;

            displayMaxRangeAndVelocity();
        }

        private void barrelTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayMaxRangeAndVelocity();
        }

        private void manSizeLabel_Click(object sender, EventArgs e)
        {
            targetSizeTextBox.Text = "1.7";
        }

        private void truckCabHeightLabel_Click(object sender, EventArgs e)
        {
            targetSizeTextBox.Text = "4";
        }

        private void abramsSizeLabel_Click(object sender, EventArgs e)
        {
            targetSizeTextBox.Text = "2.75";
        }

        private void humveeSizeLabel_Click(object sender, EventArgs e)
        {
            targetSizeTextBox.Text = "2.2";
        }

        private void lavSizeLabel_Click(object sender, EventArgs e)
        {
            targetSizeTextBox.Text = "3.5";
        }
    }
}
