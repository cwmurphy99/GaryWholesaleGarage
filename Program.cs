using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";
            fxs.Name = "Zero Hour";

            Tesla modelS = new Tesla();
            modelS.MainColor = "Red";
            modelS.Name = "Ziggy Stardust";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";

            Ram truck = new Ram();
            truck.MainColor = "Silver";

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine("");

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            //modelS.ChargeBattery();
            Console.WriteLine("");

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine("");

            truck.Drive();
            truck.Turn("left");
            truck.Stop();
            Console.WriteLine("");


            List<IElectricVehicle> ElectricVehicleList = new List<IElectricVehicle>()
            {
                fxs,
                modelS
            };

            foreach (IElectricVehicle ev in ElectricVehicleList)
            {
                ev.ChargeBattery();
                Console.WriteLine($"Charging {ev.Name} Electric Vehicle.");
                Console.WriteLine($"Percentage: {ev.CurrentChargePercentage}%");
                Console.WriteLine($"Battery Useage: {ev.BatteryKwh}!");
                Console.WriteLine("");
            }
        }
    }
}
