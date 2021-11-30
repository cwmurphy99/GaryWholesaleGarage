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
            Console.WriteLine($"The {MainColor} Cessna flashes overhead! Zoooooom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle banks to the {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle makes it halfway to the end of the runway before coming to a full stop.");
        }
    }
}