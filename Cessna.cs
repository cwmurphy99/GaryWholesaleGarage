using System;
using System.Collections.Generic;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            MainColor = "White";
            Console.WriteLine($"The {MainColor} Cessna flashes overhead! Zoooooom!");
        }
        public override void Turn()
        {
            Console.WriteLine("The vehicle makes it halfway to the end of the runway before coming to a full stop.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }
    }
}