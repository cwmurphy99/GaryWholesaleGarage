using System;
using System.Collections.Generic;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("The Vehicle turned right.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The Vehicle comes to a slow stop.");
        }
    }
}