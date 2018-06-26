using System;

namespace Automobiles
{
    public class SportsCar : IMotorVehicle
    {
        private int cargo;
        public bool AddCargo(int cargoToAdd)
        {
            if (cargoToAdd > 100) return false; //allowed to do a short if statement on one line
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
