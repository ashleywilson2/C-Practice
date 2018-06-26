using System;

namespace ExampleApp2_from_WS
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Today;

            Console.WriteLine("\nToday is: " + now.ToShortDateString() + "\n");

            Console.WriteLine("Please enter your birthday month in numerical form:");
            var bdayMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birthday day in numerical form:");
            var bdayDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your birthday year in numerical form:");
            int bdayYear = int.Parse(Console.ReadLine());


            DateTime bdayDate = new DateTime(bdayYear, bdayMonth, bdayDay);

            var days = (now - bdayDate).TotalDays;

            Console.WriteLine("\nYou are " + days + " days old");

            Console.ReadKey();
        }
    }
}
