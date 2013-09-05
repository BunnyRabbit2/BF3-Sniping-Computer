namespace BF3SnipingComputer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barrelTypeLabel = new System.Windows.Forms.Label();
            this.barrelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateDistanceButton = new System.Windows.Forms.Button();
            this.calculateMilButton = new System.Windows.Forms.Button();
            this.calculateSizeButton = new System.Windows.Forms.Button();
            this.weaponLabel = new System.Windows.Forms.Label();
            this.weaponComboBox = new System.Windows.Forms.ComboBox();
            this.sightLabel = new System.Windows.Forms.Label();
            this.sightComboBox = new System.Windows.Forms.ComboBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.milLabel = new System.Windows.Forms.Label();
            this.distanceTextBox = new System.Windows.Forms.TextBox();
            this.targetSizeTextBox = new System.Windows.Forms.TextBox();
            this.milsTextBox = new System.Windows.Forms.TextBox();
            this.maxRangeLabel = new System.Windows.Forms.Label();
            this.maxRangeOutput = new System.Windows.Forms.Label();
            this.mDropLabel = new System.Windows.Forms.Label();
            this.mDropOutput = new System.Windows.Forms.Label();
            this.timeToTargetLabel = new System.Windows.Forms.Label();
            this.timeToTargetOutput = new System.Windows.Forms.Label();
            this.velocityLabel = new System.Windows.Forms.Label();
            this.velocityOutputLabel = new System.Windows.Forms.Label();
            this.milDropLabel = new System.Windows.Forms.Label();
            this.milDropOutput = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vodnikSizeLabel = new System.Windows.Forms.Label();
            this.humveeSizeLabel = new System.Windows.Forms.Label();
            this.bmpSizeLabel = new System.Windows.Forms.Label();
            this.lavSizeLabel = new System.Windows.Forms.Label();
            this.t90SizeLabel = new System.Windows.Forms.Label();
            this.abramsSizeLabel = new System.Windows.Forms.Label();
            this.truckCabHeightLabel = new System.Windows.Forms.Label();
            this.manSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.barrelTypeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.barrelTypeComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.calculateDistanceButton);
            this.splitContainer1.Panel1.Controls.Add(this.calculateMilButton);
            this.splitContainer1.Panel1.Controls.Add(this.calculateSizeButton);
            this.splitContainer1.Panel1.Controls.Add(this.weaponLabel);
            this.splitContainer1.Panel1.Controls.Add(this.weaponComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.sightLabel);
            this.splitContainer1.Panel1.Controls.Add(this.sightComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.sizeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.distanceLabel);
            this.splitContainer1.Panel1.Controls.Add(this.milLabel);
            this.splitContainer1.Panel1.Controls.Add(this.distanceTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.targetSizeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.milsTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(439, 463);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxRangeLabel);
            this.groupBox1.Controls.Add(this.maxRangeOutput);
            this.groupBox1.Controls.Add(this.mDropLabel);
            this.groupBox1.Controls.Add(this.mDropOutput);
            this.groupBox1.Controls.Add(this.timeToTargetLabel);
            this.groupBox1.Controls.Add(this.timeToTargetOutput);
            this.groupBox1.Controls.Add(this.velocityLabel);
            this.groupBox1.Controls.Add(this.velocityOutputLabel);
            this.groupBox1.Controls.Add(this.milDropLabel);
            this.groupBox1.Controls.Add(this.milDropOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shooting Details";
            // 
            // barrelTypeLabel
            // 
            this.barrelTypeLabel.AutoSize = true;
            this.barrelTypeLabel.Location = new System.Drawing.Point(12, 150);
            this.barrelTypeLabel.Name = "barrelTypeLabel";
            this.barrelTypeLabel.Size = new System.Drawing.Size(61, 13);
            this.barrelTypeLabel.TabIndex = 43;
            this.barrelTypeLabel.Text = "Barrel Type";
            // 
            // barrelTypeComboBox
            // 
            this.barrelTypeComboBox.FormattingEnabled = true;
            this.barrelTypeComboBox.Location = new System.Drawing.Point(151, 147);
            this.barrelTypeComboBox.Name = "barrelTypeComboBox";
            this.barrelTypeComboBox.Size = new System.Drawing.Size(269, 21);
            this.barrelTypeComboBox.TabIndex = 42;
            // 
            // calculateDistanceButton
            // 
            this.calculateDistanceButton.Location = new System.Drawing.Point(345, 62);
            this.calculateDistanceButton.Name = "calculateDistanceButton";
            this.calculateDistanceButton.Size = new System.Drawing.Size(75, 23);
            this.calculateDistanceButton.TabIndex = 39;
            this.calculateDistanceButton.Text = "Calculate";
            this.calculateDistanceButton.UseVisualStyleBackColor = true;
            // 
            // calculateMilButton
            // 
            this.calculateMilButton.Location = new System.Drawing.Point(345, 33);
            this.calculateMilButton.Name = "calculateMilButton";
            this.calculateMilButton.Size = new System.Drawing.Size(75, 23);
            this.calculateMilButton.TabIndex = 40;
            this.calculateMilButton.Text = "Calculate";
            this.calculateMilButton.UseVisualStyleBackColor = true;
            // 
            // calculateSizeButton
            // 
            this.calculateSizeButton.Location = new System.Drawing.Point(345, 4);
            this.calculateSizeButton.Name = "calculateSizeButton";
            this.calculateSizeButton.Size = new System.Drawing.Size(75, 23);
            this.calculateSizeButton.TabIndex = 41;
            this.calculateSizeButton.Text = "Calculate";
            this.calculateSizeButton.UseVisualStyleBackColor = true;
            // 
            // weaponLabel
            // 
            this.weaponLabel.AutoSize = true;
            this.weaponLabel.Location = new System.Drawing.Point(12, 122);
            this.weaponLabel.Name = "weaponLabel";
            this.weaponLabel.Size = new System.Drawing.Size(48, 13);
            this.weaponLabel.TabIndex = 38;
            this.weaponLabel.Text = "Weapon";
            // 
            // weaponComboBox
            // 
            this.weaponComboBox.FormattingEnabled = true;
            this.weaponComboBox.Location = new System.Drawing.Point(151, 119);
            this.weaponComboBox.Name = "weaponComboBox";
            this.weaponComboBox.Size = new System.Drawing.Size(269, 21);
            this.weaponComboBox.TabIndex = 37;
            // 
            // sightLabel
            // 
            this.sightLabel.AutoSize = true;
            this.sightLabel.Location = new System.Drawing.Point(12, 94);
            this.sightLabel.Name = "sightLabel";
            this.sightLabel.Size = new System.Drawing.Size(31, 13);
            this.sightLabel.TabIndex = 36;
            this.sightLabel.Text = "Sight";
            // 
            // sightComboBox
            // 
            this.sightComboBox.FormattingEnabled = true;
            this.sightComboBox.Location = new System.Drawing.Point(151, 91);
            this.sightComboBox.Name = "sightComboBox";
            this.sightComboBox.Size = new System.Drawing.Size(269, 21);
            this.sightComboBox.TabIndex = 35;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(12, 9);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(89, 13);
            this.sizeLabel.TabIndex = 30;
            this.sizeLabel.Text = "Target Size (in m)";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(12, 67);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(77, 13);
            this.distanceLabel.TabIndex = 34;
            this.distanceLabel.Text = "Distance (in m)";
            // 
            // milLabel
            // 
            this.milLabel.AutoSize = true;
            this.milLabel.Location = new System.Drawing.Point(12, 38);
            this.milLabel.Name = "milLabel";
            this.milLabel.Size = new System.Drawing.Size(102, 13);
            this.milLabel.TabIndex = 31;
            this.milLabel.Text = "Target Size (in lines)";
            // 
            // distanceTextBox
            // 
            this.distanceTextBox.Location = new System.Drawing.Point(151, 64);
            this.distanceTextBox.Name = "distanceTextBox";
            this.distanceTextBox.Size = new System.Drawing.Size(188, 20);
            this.distanceTextBox.TabIndex = 33;
            // 
            // targetSizeTextBox
            // 
            this.targetSizeTextBox.Location = new System.Drawing.Point(151, 6);
            this.targetSizeTextBox.Name = "targetSizeTextBox";
            this.targetSizeTextBox.Size = new System.Drawing.Size(188, 20);
            this.targetSizeTextBox.TabIndex = 29;
            // 
            // milsTextBox
            // 
            this.milsTextBox.Location = new System.Drawing.Point(151, 35);
            this.milsTextBox.Name = "milsTextBox";
            this.milsTextBox.Size = new System.Drawing.Size(188, 20);
            this.milsTextBox.TabIndex = 32;
            // 
            // maxRangeLabel
            // 
            this.maxRangeLabel.AutoSize = true;
            this.maxRangeLabel.Location = new System.Drawing.Point(6, 47);
            this.maxRangeLabel.Name = "maxRangeLabel";
            this.maxRangeLabel.Size = new System.Drawing.Size(86, 13);
            this.maxRangeLabel.TabIndex = 42;
            this.maxRangeLabel.Text = "Maximum Range";
            // 
            // maxRangeOutput
            // 
            this.maxRangeOutput.AutoSize = true;
            this.maxRangeOutput.Location = new System.Drawing.Point(142, 47);
            this.maxRangeOutput.Name = "maxRangeOutput";
            this.maxRangeOutput.Size = new System.Drawing.Size(24, 13);
            this.maxRangeOutput.TabIndex = 41;
            this.maxRangeOutput.Text = "0 m";
            // 
            // mDropLabel
            // 
            this.mDropLabel.AutoSize = true;
            this.mDropLabel.Location = new System.Drawing.Point(6, 91);
            this.mDropLabel.Name = "mDropLabel";
            this.mDropLabel.Size = new System.Drawing.Size(52, 13);
            this.mDropLabel.TabIndex = 40;
            this.mDropLabel.Text = "Drop in m";
            // 
            // mDropOutput
            // 
            this.mDropOutput.AutoSize = true;
            this.mDropOutput.Location = new System.Drawing.Point(142, 91);
            this.mDropOutput.Name = "mDropOutput";
            this.mDropOutput.Size = new System.Drawing.Size(24, 13);
            this.mDropOutput.TabIndex = 39;
            this.mDropOutput.Text = "0 m";
            // 
            // timeToTargetLabel
            // 
            this.timeToTargetLabel.AutoSize = true;
            this.timeToTargetLabel.Location = new System.Drawing.Point(6, 69);
            this.timeToTargetLabel.Name = "timeToTargetLabel";
            this.timeToTargetLabel.Size = new System.Drawing.Size(80, 13);
            this.timeToTargetLabel.TabIndex = 38;
            this.timeToTargetLabel.Text = "Time To Target";
            // 
            // timeToTargetOutput
            // 
            this.timeToTargetOutput.AutoSize = true;
            this.timeToTargetOutput.Location = new System.Drawing.Point(142, 69);
            this.timeToTargetOutput.Name = "timeToTargetOutput";
            this.timeToTargetOutput.Size = new System.Drawing.Size(56, 13);
            this.timeToTargetOutput.TabIndex = 37;
            this.timeToTargetOutput.Text = "0 seconds";
            // 
            // velocityLabel
            // 
            this.velocityLabel.AutoSize = true;
            this.velocityLabel.Location = new System.Drawing.Point(6, 25);
            this.velocityLabel.Name = "velocityLabel";
            this.velocityLabel.Size = new System.Drawing.Size(73, 13);
            this.velocityLabel.TabIndex = 36;
            this.velocityLabel.Text = "Bullet Velocity";
            // 
            // velocityOutputLabel
            // 
            this.velocityOutputLabel.AutoSize = true;
            this.velocityOutputLabel.Location = new System.Drawing.Point(142, 25);
            this.velocityOutputLabel.Name = "velocityOutputLabel";
            this.velocityOutputLabel.Size = new System.Drawing.Size(34, 13);
            this.velocityOutputLabel.TabIndex = 35;
            this.velocityOutputLabel.Text = "0 m/s";
            // 
            // milDropLabel
            // 
            this.milDropLabel.AutoSize = true;
            this.milDropLabel.Location = new System.Drawing.Point(6, 113);
            this.milDropLabel.Name = "milDropLabel";
            this.milDropLabel.Size = new System.Drawing.Size(61, 13);
            this.milDropLabel.TabIndex = 34;
            this.milDropLabel.Text = "Drop in mils";
            // 
            // milDropOutput
            // 
            this.milDropOutput.AutoSize = true;
            this.milDropOutput.Location = new System.Drawing.Point(142, 113);
            this.milDropOutput.Name = "milDropOutput";
            this.milDropOutput.Size = new System.Drawing.Size(33, 13);
            this.milDropOutput.TabIndex = 33;
            this.milDropOutput.Text = "0 mils";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vodnikSizeLabel);
            this.groupBox2.Controls.Add(this.humveeSizeLabel);
            this.groupBox2.Controls.Add(this.bmpSizeLabel);
            this.groupBox2.Controls.Add(this.lavSizeLabel);
            this.groupBox2.Controls.Add(this.t90SizeLabel);
            this.groupBox2.Controls.Add(this.abramsSizeLabel);
            this.groupBox2.Controls.Add(this.truckCabHeightLabel);
            this.groupBox2.Controls.Add(this.manSizeLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 120);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object Sizes. Click to put in Target Size";
            // 
            // vodnikSizeLabel
            // 
            this.vodnikSizeLabel.AutoSize = true;
            this.vodnikSizeLabel.Location = new System.Drawing.Point(142, 48);
            this.vodnikSizeLabel.Name = "vodnikSizeLabel";
            this.vodnikSizeLabel.Size = new System.Drawing.Size(92, 13);
            this.vodnikSizeLabel.TabIndex = 31;
            this.vodnikSizeLabel.Text = "Vodnik = m height";
            // 
            // humveeSizeLabel
            // 
            this.humveeSizeLabel.AutoSize = true;
            this.humveeSizeLabel.Location = new System.Drawing.Point(142, 26);
            this.humveeSizeLabel.Name = "humveeSizeLabel";
            this.humveeSizeLabel.Size = new System.Drawing.Size(114, 13);
            this.humveeSizeLabel.TabIndex = 30;
            this.humveeSizeLabel.Text = "Humvee = 2.2m height";
            // 
            // bmpSizeLabel
            // 
            this.bmpSizeLabel.AutoSize = true;
            this.bmpSizeLabel.Location = new System.Drawing.Point(142, 93);
            this.bmpSizeLabel.Name = "bmpSizeLabel";
            this.bmpSizeLabel.Size = new System.Drawing.Size(82, 13);
            this.bmpSizeLabel.TabIndex = 29;
            this.bmpSizeLabel.Text = "BMP = m height";
            // 
            // lavSizeLabel
            // 
            this.lavSizeLabel.AutoSize = true;
            this.lavSizeLabel.Location = new System.Drawing.Point(142, 71);
            this.lavSizeLabel.Name = "lavSizeLabel";
            this.lavSizeLabel.Size = new System.Drawing.Size(94, 13);
            this.lavSizeLabel.TabIndex = 28;
            this.lavSizeLabel.Text = "LAV = 3.5m height";
            // 
            // t90SizeLabel
            // 
            this.t90SizeLabel.AutoSize = true;
            this.t90SizeLabel.Location = new System.Drawing.Point(6, 93);
            this.t90SizeLabel.Name = "t90SizeLabel";
            this.t90SizeLabel.Size = new System.Drawing.Size(78, 13);
            this.t90SizeLabel.TabIndex = 27;
            this.t90SizeLabel.Text = "T90 = m height";
            // 
            // abramsSizeLabel
            // 
            this.abramsSizeLabel.AutoSize = true;
            this.abramsSizeLabel.Location = new System.Drawing.Point(6, 71);
            this.abramsSizeLabel.Name = "abramsSizeLabel";
            this.abramsSizeLabel.Size = new System.Drawing.Size(133, 13);
            this.abramsSizeLabel.TabIndex = 26;
            this.abramsSizeLabel.Text = "M1 Abrams 2.75= m height";
            // 
            // truckCabHeightLabel
            // 
            this.truckCabHeightLabel.AutoSize = true;
            this.truckCabHeightLabel.Location = new System.Drawing.Point(6, 48);
            this.truckCabHeightLabel.Name = "truckCabHeightLabel";
            this.truckCabHeightLabel.Size = new System.Drawing.Size(115, 13);
            this.truckCabHeightLabel.TabIndex = 25;
            this.truckCabHeightLabel.Text = "Truck Cab = 4m height";
            // 
            // manSizeLabel
            // 
            this.manSizeLabel.AutoSize = true;
            this.manSizeLabel.Location = new System.Drawing.Point(6, 26);
            this.manSizeLabel.Name = "manSizeLabel";
            this.manSizeLabel.Size = new System.Drawing.Size(95, 13);
            this.manSizeLabel.TabIndex = 24;
            this.manSizeLabel.Text = "Man = 1.7m height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 463);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Battlefield 3 Sniping Computer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label barrelTypeLabel;
        private System.Windows.Forms.ComboBox barrelTypeComboBox;
        private System.Windows.Forms.Button calculateDistanceButton;
        private System.Windows.Forms.Button calculateMilButton;
        private System.Windows.Forms.Button calculateSizeButton;
        private System.Windows.Forms.Label weaponLabel;
        private System.Windows.Forms.ComboBox weaponComboBox;
        private System.Windows.Forms.Label sightLabel;
        private System.Windows.Forms.ComboBox sightComboBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label milLabel;
        private System.Windows.Forms.TextBox distanceTextBox;
        private System.Windows.Forms.TextBox targetSizeTextBox;
        private System.Windows.Forms.TextBox milsTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label vodnikSizeLabel;
        private System.Windows.Forms.Label humveeSizeLabel;
        private System.Windows.Forms.Label bmpSizeLabel;
        private System.Windows.Forms.Label lavSizeLabel;
        private System.Windows.Forms.Label t90SizeLabel;
        private System.Windows.Forms.Label abramsSizeLabel;
        private System.Windows.Forms.Label truckCabHeightLabel;
        private System.Windows.Forms.Label manSizeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label maxRangeLabel;
        private System.Windows.Forms.Label maxRangeOutput;
        private System.Windows.Forms.Label mDropLabel;
        private System.Windows.Forms.Label mDropOutput;
        private System.Windows.Forms.Label timeToTargetLabel;
        private System.Windows.Forms.Label timeToTargetOutput;
        private System.Windows.Forms.Label velocityLabel;
        private System.Windows.Forms.Label velocityOutputLabel;
        private System.Windows.Forms.Label milDropLabel;
        private System.Windows.Forms.Label milDropOutput;
    }
}

