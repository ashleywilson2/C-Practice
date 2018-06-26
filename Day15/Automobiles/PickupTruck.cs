using System;
using System.Collections.Generic;
using System.Text;

namespace Automobiles
{
    public class PickupTruck : IMotorVehicle
    {
        private int cargo;
        public bool AddCargo(int cargoToAdd)
        {
            if (cargoToAdd > 2000) return false; //allowed to do a short if statement on one line
            cargo = cargoToAdd;
            return true;
        }

        public void MoveForOneHour()
        {
            //empty
        }

        public int GetDistanceTravelled()
        {
            return 0;
        }
    }
}
