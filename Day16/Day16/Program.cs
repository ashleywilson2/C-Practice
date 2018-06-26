using System;

namespace Breakfast
{
    class Program
    {
        static void Main(string[] args)
        {
            var oatmealProcess = new OatmealCookProcess();
            var eggProcess = new EggCookProcess();

            oatmealProcess.Cook();
            eggProcess.Cook();

            Console.ReadKey();

        }
    }
}
