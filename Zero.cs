using System;
using System.Collections.Generic;

namespace Garage
{
    public class Zero : Vehicle //Electric Motorcycle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {
            //method definition omitted
        }
        public override void Drive()
        {
            MainColor = "Midnight Blue";
            Console.WriteLine($"The {MainColor} Zero zips by you! Yeeeeeoooowww!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle silently turns right.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a complete, and noiseless stop!");
        }
    }
}