using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            //my version of Exercise 1
            //var today = DateTime.Now;
            //var utcTime = DateTime.UtcNow;
            //var difference = today.Subtract(utcTime);
            //Console.WriteLine(today);
            //Console.WriteLine(utcTime);
            //Console.WriteLine(difference);
            //Console.ReadKey();

            //Derick's version of Exercise 1 using the debug under the properties tab setting the args as:
                //2018-06-22T08:00:00 2018-06-22T09:00:00
            var result = DateTime.Parse(args[1]) - DateTime.Parse(args[0]);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
