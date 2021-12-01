using System;

namespace Garage
{
    public interface IElectricVehicle
    {
        double BatteryKwh { get; set; }
        double CurrentChargePercentage { get; set; }
        string Name { get; set; }
        void ChargeBattery();
    }
}