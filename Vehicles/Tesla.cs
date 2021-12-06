using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class Tesla : Vehicle, IElectricVehicle //Electric Car
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKwh { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes past you! Mmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle quietly makes a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle buzzes to a complete stop.");
        }
        public void ChargeBattery()
        {
            BatteryKwh = 62;
            CurrentChargePercentage = 100;
        }
    }
}