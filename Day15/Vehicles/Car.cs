using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : IBreakable, IHasPassengers, IMotored, IHasWheels
    {
        public void HitTheBreaks()
        {
            throw new NotImplementedException();
        }
    }
}
