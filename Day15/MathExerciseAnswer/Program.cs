using System;
using System.Collections.Generic;

namespace MathExerciseAnswer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            foreach(var arg in args)
            {
                numbers.Add(int.Parse(arg));   //turning strings into ints
            }

            var function = new Sum();

            Execute(function, numbers);

            Console.ReadKey();
        }

        static void Execute(IAggregate function, List<int> numbers) //passing the list of ints from the command line (args) into the execute
        {
            foreach (var number in numbers)
            {
                function.Insert(number);
            }
            Console.WriteLine(function.Calculate());
        }
    }
}
