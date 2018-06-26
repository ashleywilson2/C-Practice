using System;

namespace Delta
{
    class Program
    {
        static void Main(string[] args)
        {
            var approved = true;
            while (approved)
            {
                //Lots of code
                Console.WriteLine("While Loop");
                approved = false;
                //break; //stops the loop after it runs once and doesn't return back to the while
            }

            do //always executes once
            {
                Console.WriteLine("Do Loop");
                approved = false;
            } while (approved);




            Console.ReadKey();
        }
    }
}
