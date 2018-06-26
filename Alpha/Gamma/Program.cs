using System;
using System.Text;
namespace Gamma
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = "One";
            var value2 = "Two";

            //var value3 = value1 + value2;

            //var value3 = string.Concat(value1, value2); //params means it can take a lot of stuff

            var value3 = string.Format("{0}{1}", value1, value2); //antiquated version of string.concat

            var value4 = $"{value1}{value2}";  //string interpolation

            var 

            //Console.WriteLine(value3);
            Console.WriteLine(value4);

            //var sb = new StringBuilder();
            //foreach (var item in args)
            //{
            //    sb.Append(item);
            //}
            //var myString = sb.ToString();

            var sb = new StringBuilder();
            sb.Append(value1);
            sb.Append(value2);
            var value5 = sb.ToString();

            Console.ReadKey();
        }
    }
}
