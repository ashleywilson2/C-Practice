using System;
using System.Collections.Generic;
using System.Text;

namespace Breakfast
{
    public class OatmealCookProcess : CookProcess
    {
        protected override void ApplyFoodToCooker()
        {
            Console.WriteLine("Putting oatmeal in microwave.");
        }

        protected override void TurnOffCooker()
        {
            Console.WriteLine("Turn off microwave for oatmeal!");
        }

        protected override void TurnOnCooker()
        {
            Console.WriteLine("Turning on microwave for oatmeal!");
        }
    }
}
