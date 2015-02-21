using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ets.Telemetry.Server.Data;
using Ets.Telemetry.Server.Data.Reader;

namespace ExampleProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void statusUpdateTimer_Tick(object sender, EventArgs e)
        {
            var data = Ets2TelemetryDataReader.Instance.Read();

            speedIndicator.Text = data.TruckSpeed.ToString();
            RpmIndicator.Text = data.EngineRpm.ToString();
            fuelIndicator.Text = data.Fuel.ToString();
            fuelCapacityIndicator.Text = data.FuelCapacity.ToString();
            fuelPercentageIndicator.Text = ((data.Fuel / data.FuelCapacity) * 100).ToString();
            leftIndicatorIndicator.Text = data.BlinkerLeftOn.ToString();
            rightIndicatorIndicator.Text = data.BlinkerRightOn.ToString();
            modelLengthIndicator.Text = data.TruckModelLength.ToString();
            breakHeatIndicator.Text = data.BrakeTemperature.ToString();
            batteryVoltageIndicator.Text = data.BatteryVoltage.ToString();
            oilPressureIndicator.Text = data.OilPressure.ToString();
            oilTemperatureIndicator.Text = data.OilTemperature.ToString();
            airPressureIndicator.Text = data.AirPressure.ToString();
            odometerIndicator.Text = data.TruckOdometer.ToString();
            wipersIndicator.Text = data.WipersOn.ToString();
            trailerNameIndicator.Text = data.TrailerName.ToString();
            trailerAttachedIndicator.Text = data.TrailerAttached.ToString();
            sourceCityIndicator.Text = data.SourceCity;
            destinationCityIndicator.Text = data.DestinationCity;
            averageFuelConsumptionIndicator.Text = data.FuelAverageConsumption.ToString();
            gameTimeIndicator.Text = data.GameTime.ToShortTimeString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


    }
} 