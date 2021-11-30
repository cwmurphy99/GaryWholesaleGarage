using System;
using System.Collections.Generic;

namespace Garage
{
    public class Ram : Vehicle //Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            //method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles past! Rrruummmbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The vehicle quckly lumbers around a {direction} turn");
        }
        public override void Stop()
        {
            Console.WriteLine("The vehicle quickly comes to a full stop!");
        }
    }
}