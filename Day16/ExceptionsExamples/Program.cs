using System;

namespace ExceptionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            try //execute and watch for exceptions
            {
                var bob = new Person(20);
                var alice = new Person(-12);
            }
            catch (InvalidAgeException) //can be multiple catch blocks
            {
                //Age Problem
                Console.WriteLine("There was a problem creating the person objects.");
            }
            finally
            {
                //ALWAYS RUNS (actually optional)
            }

            Console.ReadKey();
        }
    }
}
