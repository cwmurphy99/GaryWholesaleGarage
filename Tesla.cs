using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle //Electric Car
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {
            //method definition omitted
        }
        public override void Drive()
        {
            MainColor = "Red";
            Console.WriteLine($"The {MainColor} Tesla blazes past you! Mmmmmmm!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle quietly makes a left turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle buzzes to a complete stop.");
        }
    }
}