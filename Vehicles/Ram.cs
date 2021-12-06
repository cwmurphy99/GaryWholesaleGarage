using System;
using System.Collections.Generic;

namespace Vehicles
{
    public class Ram : Vehicle, IGasVehicles //Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 23;
            CurrentTankPercentage = 100;
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