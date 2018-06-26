using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new string[]
            {
                "Apple",
                "Banana",
                null,
                "Cherry"
            };
            
            foreach (var fruit in data)
            {
                if (fruit == null)
                {
                    Console.WriteLine("@");
                }
                else
                {
                    Console.WriteLine(fruit);
                }
            }


            Console.ReadKey();
        }
    }
}
