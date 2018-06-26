//Exercise:  Write a new console application.It will accept any number of command line arguments.  The application will add all of the values together, and print the result of the addition.  (For example, “1 2 3” prints “6").   Once that is working, make the application tolerant of BAD values, and just ignore those values.  (Example, “1 2 zebra 3” prints “6").  (The “zebra” value is to be totally ignored.)


using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 0;
            foreach (var stringValue in args)
            {
                //var intValue = int.Parse(stringValue);

                if (int.TryParse(stringValue, out int intValue))
                {
                    // SUCCESS
                    result = result + intValue;
                }
                               
                //result += intValue is shorthand for incrementing a value
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
