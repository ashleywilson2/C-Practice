using System;

namespace Exercise4Answer
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 0;
            foreach (var arg in args)
            {
                if (int.TryParse(arg, out int value))
                {
                    if (value <= 100)
                    {
                        total += value;
                        var isSpecial = false;
                        switch (value)
                        {
                            case 3:
                            case 7:
                            case 13:
                                isSpecial = true;
                                break;
                        }
                        var isEven = value % 2 == 0;
                        var description = String.Empty;
                        if (isSpecial)
                        {
                            description = "SPECIAL";
                        }
                        else
                        {
                            description = isEven ? "EVEN" : "ODD";
                            //if (isEven)
                            //{
                            //    description = "EVEN";
                            //}
                            //else
                            //{
                            //    description = "ODD";
                            //}
                        }
                        Console.WriteLine($"{value}({description})");
                    }
                }
            }
            Console.WriteLine(total.ToString());
            Console.ReadKey();
        }
    }
}
