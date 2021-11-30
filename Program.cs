using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truck = new Ram();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            Console.WriteLine("");

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            Console.WriteLine("");

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            Console.WriteLine("");

            truck.Turn();
            truck.Drive();
            truck.Stop();
            Console.WriteLine("");
        }
    }
}
