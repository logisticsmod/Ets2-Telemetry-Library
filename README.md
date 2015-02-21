# Ets2-Telemetry-Library
# About
Ets2 Telemetry Library is based off code by funbit located at: https://github.com/Funbit/ets2-telemetry-server. It has been reworked into a c# COM library making it very easy to get data from the Euro Truck Simulator not only in c# but also other languages that support COM libaries.
#usage
Ets2 Telemetry Library is very easy to use. First you need to include the required parts in your program. In c# this would look like:
```c#
using Ets.Telemetry.Server.Data;
using Ets.Telemetry.Server.Data.Reader;
```

Then when you need the data, you would assign the value returned by ```Ets2TelemetryDataReader.Instance.Read()``` to a variable which in C# would look like this:
```c#
var data = Ets2TelemetryDataReader.Instance.Read();
```

Finally, to actually read the information, you would call `data.<whatyouwant>` for example, in C# if I wanted to set the value of a label to the current speed of the truck, it would look like this:
```c#
speedIndicator.Text = data.TruckSpeed.ToString();
```

In the included example, we have this code:
```c#
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
```

inside of a timer tick event so we can change how often the information in the form is updated by changing the Interval of the timer.
#License
This Code is released under the Mit License
