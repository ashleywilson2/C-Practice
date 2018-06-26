using System;

namespace Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            var Bob = new Person();
            var Alice = new Person();

            Bob.Name = "Bob";
            Bob.Age = 30;

            Alice.Name = "Alice";
            Alice.Age = 25;

            var Charlie = new Person();
            Charlie.Name = "Charlie";
            Charlie.Age = 55;

            Charlie = Alice;

            Charlie.Age = 88;

            ///////////////////////////////////////////////////////////////////////////////////////////////

            var value1 = 10;
            var value2 = 20;
            var value3 = value2;

            value3 = 5000;

            Console.ReadKey();

        }
    }
}
