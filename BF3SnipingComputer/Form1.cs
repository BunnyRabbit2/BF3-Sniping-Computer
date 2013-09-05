using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private List<string> weaponsFileList;
        private List<string> sightsFileList;
        private List<string> barrelTypes;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
