using System;

namespace Charlie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apple, Banana, or Strawberry?");
            Console.ReadLine();
            var value = "Banana";
            //string values ARE case-sensitive!!! must match EXACTLY or else will return the default value
            switch (value)
            {
                case "Apple":
                    Console.WriteLine("One");
                    break;
                case "Banana":
                    Console.WriteLine("Two");
                    break;
                case "Strawberry":
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("BAD VALUE!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
