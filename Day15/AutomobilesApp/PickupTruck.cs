using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobilesApp
{
    class PickupTruck : IMotorVehicle
    {
        public void Go()
        {
            Console.WriteLine("I can carry lots of heavy stuff!");
        }
    }
}
