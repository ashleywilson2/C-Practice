using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesV2
{
    public class FuelEfficientVehicle : MotorVehicle
    {
        protected override int CalculateFuelDepletion()
        {
            return 1;
        }
    }
}
