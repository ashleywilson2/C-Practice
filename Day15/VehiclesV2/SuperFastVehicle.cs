using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesV2
{
    public class SuperFastVehicle : MotorVehicle
    {
        protected override int CalculateFuelDepletion()
        {
            return 45;
        }
    }
}
