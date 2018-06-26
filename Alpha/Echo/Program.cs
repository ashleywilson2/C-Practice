using System;

namespace Echo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 0; i < 5; i++)
            //{
               // Console.WriteLine("Value" + i.ToString());

                //var c = '5'; single quotes is a character (char)
                //a string is an array of characters
            //}

            //foreach (var dateString in args)
            //{
            //    var date = DateTime.Parse(dateString);
            //    date = date.AddMonths(6);
            //    Console.WriteLine(date.ToString("MM^yyyy")); //putting stuff inside of the ToString changes the default settings on the machine you are running the app
            //}

            foreach (var c in "test")
            {
                Console.WriteLine(c);  //writes the word "test" character by character...remember a string is an array of c's
            }

            Console.ReadKey();
        }

        
    }
}
