using System;
using System.Collections.Generic;
using System.Text;

namespace Automobiles
{
    public interface IMotorVehicle
    {
        bool AddCargo(int cargoToAdd);
        void MoveForOneHour();
        int GetDistanceTravelled();
    }
}
