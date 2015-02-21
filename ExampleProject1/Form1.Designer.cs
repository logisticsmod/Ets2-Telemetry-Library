namespace ExampleProject1
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
            this.components = new System.ComponentModel.Container();
            this.statusUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.batteryVoltageIndicator = new System.Windows.Forms.Label();
            this.breakHeatIndicator = new System.Windows.Forms.Label();
            this.modelLengthIndicator = new System.Windows.Forms.Label();
            this.rightIndicatorIndicator = new System.Windows.Forms.Label();
            this.leftIndicatorIndicator = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.fuelPercentageIndicator = new System.Windows.Forms.Label();
            this.fuelCapacityIndicator = new System.Windows.Forms.Label();
            this.fuelIndicator = new System.Windows.Forms.Label();
            this.RpmIndicator = new System.Windows.Forms.Label();
            this.speedIndicator = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.oilPressureIndicator = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.oilTemperatureIndicator = new System.Windows.Forms.Label();
            this.labeloiltemp = new System.Windows.Forms.Label();
            this.airPressureIndicator = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.odometerIndicator = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.wipersIndicator = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trailerNameIndicator = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.trailerAttachedIndicator = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.sourceCityIndicator = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.destinationCityIndicator = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.averageFuelConsumptionIndicator = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gameTimeIndicator = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusUpdateTimer
            // 
            this.statusUpdateTimer.Enabled = true;
            this.statusUpdateTimer.Interval = 50;
            this.statusUpdateTimer.Tick += new System.EventHandler(this.statusUpdateTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gameTimeIndicator);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.averageFuelConsumptionIndicator);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.destinationCityIndicator);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.sourceCityIndicator);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.trailerAttachedIndicator);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.trailerNameIndicator);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.wipersIndicator);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.odometerIndicator);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.airPressureIndicator);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.oilTemperatureIndicator);
            this.tabPage1.Controls.Add(this.labeloiltemp);
            this.tabPage1.Controls.Add(this.oilPressureIndicator);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.batteryVoltageIndicator);
            this.tabPage1.Controls.Add(this.breakHeatIndicator);
            this.tabPage1.Controls.Add(this.modelLengthIndicator);
            this.tabPage1.Controls.Add(this.rightIndicatorIndicator);
            this.tabPage1.Controls.Add(this.leftIndicatorIndicator);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.fuelPercentageIndicator);
            this.tabPage1.Controls.Add(this.fuelCapacityIndicator);
            this.tabPage1.Controls.Add(this.fuelIndicator);
            this.tabPage1.Controls.Add(this.RpmIndicator);
            this.tabPage1.Controls.Add(this.speedIndicator);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(579, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // batteryVoltageIndicator
            // 
            this.batteryVoltageIndicator.AutoSize = true;
            this.batteryVoltageIndicator.Location = new System.Drawing.Point(111, 120);
            this.batteryVoltageIndicator.Name = "batteryVoltageIndicator";
            this.batteryVoltageIndicator.Size = new System.Drawing.Size(88, 13);
            this.batteryVoltageIndicator.TabIndex = 19;
            this.batteryVoltageIndicator.Text = "Fuel Percentage:";
            // 
            // breakHeatIndicator
            // 
            this.breakHeatIndicator.AutoSize = true;
            this.breakHeatIndicator.Location = new System.Drawing.Point(111, 107);
            this.breakHeatIndicator.Name = "breakHeatIndicator";
            this.breakHeatIndicator.Size = new System.Drawing.Size(74, 13);
            this.breakHeatIndicator.TabIndex = 18;
            this.breakHeatIndicator.Text = "Fuel Capacity:";
            // 
            // modelLengthIndicator
            // 
            this.modelLengthIndicator.AutoSize = true;
            this.modelLengthIndicator.Location = new System.Drawing.Point(111, 94);
            this.modelLengthIndicator.Name = "modelLengthIndicator";
            this.modelLengthIndicator.Size = new System.Drawing.Size(30, 13);
            this.modelLengthIndicator.TabIndex = 17;
            this.modelLengthIndicator.Text = "Fuel:";
            // 
            // rightIndicatorIndicator
            // 
            this.rightIndicatorIndicator.AutoSize = true;
            this.rightIndicatorIndicator.Location = new System.Drawing.Point(111, 81);
            this.rightIndicatorIndicator.Name = "rightIndicatorIndicator";
            this.rightIndicatorIndicator.Size = new System.Drawing.Size(34, 13);
            this.rightIndicatorIndicator.TabIndex = 16;
            this.rightIndicatorIndicator.Text = "RPM:";
            // 
            // leftIndicatorIndicator
            // 
            this.leftIndicatorIndicator.AutoSize = true;
            this.leftIndicatorIndicator.Location = new System.Drawing.Point(111, 68);
            this.leftIndicatorIndicator.Name = "leftIndicatorIndicator";
            this.leftIndicatorIndicator.Size = new System.Drawing.Size(41, 13);
            this.leftIndicatorIndicator.TabIndex = 15;
            this.leftIndicatorIndicator.Text = "Speed:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Battery Voltage:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Brake Heat:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Model Length:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Right Indicator:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Left Indicator:";
            // 
            // fuelPercentageIndicator
            // 
            this.fuelPercentageIndicator.AutoSize = true;
            this.fuelPercentageIndicator.Location = new System.Drawing.Point(111, 55);
            this.fuelPercentageIndicator.Name = "fuelPercentageIndicator";
            this.fuelPercentageIndicator.Size = new System.Drawing.Size(88, 13);
            this.fuelPercentageIndicator.TabIndex = 9;
            this.fuelPercentageIndicator.Text = "Fuel Percentage:";
            // 
            // fuelCapacityIndicator
            // 
            this.fuelCapacityIndicator.AutoSize = true;
            this.fuelCapacityIndicator.Location = new System.Drawing.Point(111, 42);
            this.fuelCapacityIndicator.Name = "fuelCapacityIndicator";
            this.fuelCapacityIndicator.Size = new System.Drawing.Size(74, 13);
            this.fuelCapacityIndicator.TabIndex = 8;
            this.fuelCapacityIndicator.Text = "Fuel Capacity:";
            // 
            // fuelIndicator
            // 
            this.fuelIndicator.AutoSize = true;
            this.fuelIndicator.Location = new System.Drawing.Point(111, 29);
            this.fuelIndicator.Name = "fuelIndicator";
            this.fuelIndicator.Size = new System.Drawing.Size(30, 13);
            this.fuelIndicator.TabIndex = 7;
            this.fuelIndicator.Text = "Fuel:";
            // 
            // RpmIndicator
            // 
            this.RpmIndicator.AutoSize = true;
            this.RpmIndicator.Location = new System.Drawing.Point(111, 16);
            this.RpmIndicator.Name = "RpmIndicator";
            this.RpmIndicator.Size = new System.Drawing.Size(34, 13);
            this.RpmIndicator.TabIndex = 6;
            this.RpmIndicator.Text = "RPM:";
            // 
            // speedIndicator
            // 
            this.speedIndicator.AutoSize = true;
            this.speedIndicator.Location = new System.Drawing.Point(111, 3);
            this.speedIndicator.Name = "speedIndicator";
            this.speedIndicator.Size = new System.Drawing.Size(41, 13);
            this.speedIndicator.TabIndex = 5;
            this.speedIndicator.Text = "Speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fuel Percentage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fuel Capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fuel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RPM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(579, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // oilPressureIndicator
            // 
            this.oilPressureIndicator.AutoSize = true;
            this.oilPressureIndicator.Location = new System.Drawing.Point(111, 133);
            this.oilPressureIndicator.Name = "oilPressureIndicator";
            this.oilPressureIndicator.Size = new System.Drawing.Size(88, 13);
            this.oilPressureIndicator.TabIndex = 21;
            this.oilPressureIndicator.Text = "Fuel Percentage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Oil Pressure:";
            // 
            // oilTemperatureIndicator
            // 
            this.oilTemperatureIndicator.AutoSize = true;
            this.oilTemperatureIndicator.Location = new System.Drawing.Point(111, 146);
            this.oilTemperatureIndicator.Name = "oilTemperatureIndicator";
            this.oilTemperatureIndicator.Size = new System.Drawing.Size(88, 13);
            this.oilTemperatureIndicator.TabIndex = 23;
            this.oilTemperatureIndicator.Text = "Fuel Percentage:";
            // 
            // labeloiltemp
            // 
            this.labeloiltemp.AutoSize = true;
            this.labeloiltemp.Location = new System.Drawing.Point(8, 146);
            this.labeloiltemp.Name = "labeloiltemp";
            this.labeloiltemp.Size = new System.Drawing.Size(85, 13);
            this.labeloiltemp.TabIndex = 22;
            this.labeloiltemp.Text = "Oil Temperature:";
            // 
            // airPressureIndicator
            // 
            this.airPressureIndicator.AutoSize = true;
            this.airPressureIndicator.Location = new System.Drawing.Point(111, 159);
            this.airPressureIndicator.Name = "airPressureIndicator";
            this.airPressureIndicator.Size = new System.Drawing.Size(88, 13);
            this.airPressureIndicator.TabIndex = 25;
            this.airPressureIndicator.Text = "Fuel Percentage:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Air Pressure:";
            // 
            // odometerIndicator
            // 
            this.odometerIndicator.AutoSize = true;
            this.odometerIndicator.Location = new System.Drawing.Point(111, 172);
            this.odometerIndicator.Name = "odometerIndicator";
            this.odometerIndicator.Size = new System.Drawing.Size(88, 13);
            this.odometerIndicator.TabIndex = 27;
            this.odometerIndicator.Text = "Fuel Percentage:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Odometer:";
            // 
            // wipersIndicator
            // 
            this.wipersIndicator.AutoSize = true;
            this.wipersIndicator.Location = new System.Drawing.Point(111, 185);
            this.wipersIndicator.Name = "wipersIndicator";
            this.wipersIndicator.Size = new System.Drawing.Size(88, 13);
            this.wipersIndicator.TabIndex = 29;
            this.wipersIndicator.Text = "Fuel Percentage:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Wipers:";
            // 
            // trailerNameIndicator
            // 
            this.trailerNameIndicator.AutoSize = true;
            this.trailerNameIndicator.Location = new System.Drawing.Point(111, 198);
            this.trailerNameIndicator.Name = "trailerNameIndicator";
            this.trailerNameIndicator.Size = new System.Drawing.Size(88, 13);
            this.trailerNameIndicator.TabIndex = 31;
            this.trailerNameIndicator.Text = "Fuel Percentage:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Trailer Name:";
            // 
            // trailerAttachedIndicator
            // 
            this.trailerAttachedIndicator.AutoSize = true;
            this.trailerAttachedIndicator.Location = new System.Drawing.Point(111, 211);
            this.trailerAttachedIndicator.Name = "trailerAttachedIndicator";
            this.trailerAttachedIndicator.Size = new System.Drawing.Size(88, 13);
            this.trailerAttachedIndicator.TabIndex = 33;
            this.trailerAttachedIndicator.Text = "Fuel Percentage:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Trailer Attached:";
            // 
            // sourceCityIndicator
            // 
            this.sourceCityIndicator.AutoSize = true;
            this.sourceCityIndicator.Location = new System.Drawing.Point(111, 224);
            this.sourceCityIndicator.Name = "sourceCityIndicator";
            this.sourceCityIndicator.Size = new System.Drawing.Size(88, 13);
            this.sourceCityIndicator.TabIndex = 35;
            this.sourceCityIndicator.Text = "Fuel Percentage:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 224);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Source City:";
            // 
            // destinationCityIndicator
            // 
            this.destinationCityIndicator.AutoSize = true;
            this.destinationCityIndicator.Location = new System.Drawing.Point(111, 237);
            this.destinationCityIndicator.Name = "destinationCityIndicator";
            this.destinationCityIndicator.Size = new System.Drawing.Size(88, 13);
            this.destinationCityIndicator.TabIndex = 37;
            this.destinationCityIndicator.Text = "Fuel Percentage:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 237);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 36;
            this.label20.Text = "Destination City:";
            // 
            // averageFuelConsumptionIndicator
            // 
            this.averageFuelConsumptionIndicator.AutoSize = true;
            this.averageFuelConsumptionIndicator.Location = new System.Drawing.Point(111, 250);
            this.averageFuelConsumptionIndicator.Name = "averageFuelConsumptionIndicator";
            this.averageFuelConsumptionIndicator.Size = new System.Drawing.Size(88, 13);
            this.averageFuelConsumptionIndicator.TabIndex = 39;
            this.averageFuelConsumptionIndicator.Text = "Fuel Percentage:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 250);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "AVG Fuel Con:";
            // 
            // gameTimeIndicator
            // 
            this.gameTimeIndicator.AutoSize = true;
            this.gameTimeIndicator.Location = new System.Drawing.Point(111, 263);
            this.gameTimeIndicator.Name = "gameTimeIndicator";
            this.gameTimeIndicator.Size = new System.Drawing.Size(88, 13);
            this.gameTimeIndicator.TabIndex = 41;
            this.gameTimeIndicator.Text = "Fuel Percentage:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 263);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Game Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer statusUpdateTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label fuelPercentageIndicator;
        private System.Windows.Forms.Label fuelCapacityIndicator;
        private System.Windows.Forms.Label fuelIndicator;
        private System.Windows.Forms.Label RpmIndicator;
        private System.Windows.Forms.Label speedIndicator;
        private System.Windows.Forms.Label batteryVoltageIndicator;
        private System.Windows.Forms.Label breakHeatIndicator;
        private System.Windows.Forms.Label modelLengthIndicator;
        private System.Windows.Forms.Label rightIndicatorIndicator;
        private System.Windows.Forms.Label leftIndicatorIndicator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label oilPressureIndicator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label odometerIndicator;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label airPressureIndicator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label oilTemperatureIndicator;
        private System.Windows.Forms.Label labeloiltemp;
        private System.Windows.Forms.Label wipersIndicator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label trailerNameIndicator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label trailerAttachedIndicator;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label destinationCityIndicator;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label sourceCityIndicator;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label averageFuelConsumptionIndicator;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label gameTimeIndicator;
        private System.Windows.Forms.Label label21;
    }
}

