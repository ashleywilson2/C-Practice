using System;

namespace ActionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Execute();
            //Action exec = Execute;
            //Func<bool> execBool = ExecuteBool;
            //exec();
            //var result = execBool();

            //lambda - anonymous method (no name) - used for very tiny methods
            //Action<int, string> doStuff = (i, s) => 
            //{
            //    Console.WriteLine("This is the body of an anonymous method. " + i.ToString() + " " + s);
            //};
            //doStuff(99, "Chris");

            Func<int, string, bool> doStuff = (i, s) =>
            {
                Console.WriteLine("This is the body of an anonymous method. " + i.ToString() + " " + s);
                return true;
            };
            var result = doStuff(99, "Chris");

            Console.ReadKey();
        }

        static void Execute()
        {
            Console.WriteLine("Execute was called.");
        }

        static bool ExecuteBool()
        {
            Console.WriteLine("ExecuteBool was called.");
            return true;
        }
    }
}
