using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    public abstract class CookProcess : ICookable
    {
        protected abstract void TurnOnCooker();
        protected abstract void ApplyFoodToCooker();
        protected abstract void TurnOffCooker();

        public void Cook()
        {
            TurnOnCooker();
            ApplyFoodToCooker();
            TurnOffCooker();
        }
    }
}
