using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle //Electric Motorcycle
    {
        public double CurrentChargePercentage { get; set; }
        public double BatteryKwh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you! Yeeeeeoooowww!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle silently turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a complete, and noiseless stop!");
        }

        public void ChargeBattery()
        {
            BatteryKwh = 42;
            CurrentChargePercentage = 100;
        }
    }
}