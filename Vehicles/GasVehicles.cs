using System;

namespace Vehicles
{
    public interface IGasVehicles
    {
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }
        string Name { get; set; }
        void RefuelTank();
    }
}