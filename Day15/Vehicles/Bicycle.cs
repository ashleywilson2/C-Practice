using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bicycle : IBreakable, IHasWheels, ITwoWheeled
    {
        public void ActivateKickstand()
        {
            throw new NotImplementedException();
        }

        public void HitTheBreaks()
        {
            throw new NotImplementedException();
        }
    }
}
