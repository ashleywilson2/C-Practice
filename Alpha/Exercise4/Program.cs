//Imputs will be integers, from command line, and there will be some bad (i.e non-integer) values.  Bad values will be ignored.  The output will be a list of all values, with a description of the number (e.g. "1(ODD)" and "2(EVEN)").  The numbers 3, 7, and 13 are special (e.g. "7(SPECIAL)").  Numbers over 100 are ignored (just like invalid values).  Ecample input:  1 2 3 4 giraffe 5 1008 1009 6 zebra
//Expected output (multiple lines):
//1(ODD) 2(EVEN) 3(SPECIAL) 4(EVEN) 5(ODD) 6(EVEN)
//Bonus:  A final line that has the total of all included values.
using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var number in args)
            {
                
                if (int.TryParse(number, out int result) && result < 100)
                {
                    var isSpecial = result == 3 || result == 7 || result == 13;
                    var isEven = result % 2 == 0;
                    var description = String.Empty;
                    if (isSpecial)
                    {
                        description = "SPECIAL";
                    }
                    else
                    {
                        description = isEven ? "EVEN" : "ODD";
                    }

                    Console.WriteLine($"{result}({description})"); //string interpolation
                }
            }
            Console.ReadKey();
        }
    }
}
