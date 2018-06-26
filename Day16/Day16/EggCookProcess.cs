using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    public class EggCookProcess : CookProcess
    {
        protected override void ApplyFoodToCooker()
        {
            Console.WriteLine("Put eggs in skillet!");
        }

        protected override void TurnOffCooker()
        {
            Console.WriteLine("Turned off stove!");
        }

        protected override void TurnOnCooker()
        {
            Console.WriteLine("Turned on stove!");
        }
    }
}
