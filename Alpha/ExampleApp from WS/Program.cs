using System;

namespace Beta
{
    class Program
    {
        // I declared a private variable that only has scope in class Program
        private static string first;
        private static string second;

        static void Main(string[] args)
        {
            Console.WriteLine("Please make sure that the second date is later than the first one please!");
            // This lets you take input inside command line
            if (args.Length == 0)
            {
                Console.Write("Please enter your first time: ");
                first = Console.ReadLine();  // First date
                Console.Write("Please enter your second time: ");
                second = Console.ReadLine(); // Second date
            }

            // Parse (convert) to proper formate
            DateTime parsedDate = DateTime.Parse(first);
            DateTime parsedDateSecond = DateTime.Parse(second);

            // Difference between times
            var difference = parsedDate.Subtract(parsedDateSecond);


            // Print result
            Console.WriteLine("The difference is: ");
            Console.WriteLine(difference);


            Console.ReadKey();

        }
    }
}