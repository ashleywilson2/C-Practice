using System;

namespace Beta
{
    class Program
    {
        static void Main(string[] args)
        {
            var approved = true;

            //change the value to False and No will pop up
            //OR you can do this: if (!approved) to change approved to false

            if (approved)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

            Console.ReadKey();
        }
    }
}
