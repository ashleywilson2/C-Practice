using System;

namespace Foxtrot
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value = null;

            //if (value == null || value == "")
            //{
            //    //It was null, do stuff that is null-related
            //}

            //if (string.IsNullOrEmpty(value))
            //{
            //    Console.WriteLine("");
            //}

            string value = null;
            var x = value ?? "It was null";



            Console.ReadKey();
        }
    }
}
