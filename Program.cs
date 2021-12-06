using System;
using System.Collections.Generic;
using Vehicles;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero
            {
                MainColor = "Midnight Blue",
                Name = "Zero Hour"
            };

            Tesla modelS = new Tesla
            {
                MainColor = "Red",
                Name = "Ziggy Stardust"
            };

            Cessna mx410 = new Cessna
            {
                MainColor = "White",
                Name = "Zippin Pippin",
                CurrentTankPercentage = 50
            };

            Ram truck = new Ram
            {
                MainColor = "Silver",
                Name = "Bob",
                CurrentTankPercentage = 42
            };

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();
            Console.WriteLine("");

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
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
                Console.WriteLine($"Battery Useage: {ev.BatteryKwh} Kwh!");
                Console.WriteLine("");
            }

            List<IGasVehicles> GasVehiclesList = new List<IGasVehicles>()
            {
                truck,
                mx410
            };

            foreach (IGasVehicles gv in GasVehiclesList)
            {
                Console.WriteLine($"Checking Fuel for: {gv.Name}");
                Console.WriteLine($"Current Tank Percentage: {gv.CurrentTankPercentage}");
                gv.RefuelTank();
                Console.WriteLine($"Tank has been refueld.  Current Percentage: {gv.CurrentTankPercentage}");
                Console.WriteLine("");

            }
        }
    }
}
