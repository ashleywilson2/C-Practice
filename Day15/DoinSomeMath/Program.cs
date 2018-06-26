using System;

//Exercise:
//A new interface, IAggregate (or IAggregateFunction)
//  Interface contains two methods: void Add(int value), and int Calculate()
//Write TWO new classes:  Sum and Average
//Both classes implement the interface, but each does different math
//From some calling code, use both classes via their interfaces.
//  (Forexample, a loop over a list that contains one of each aggregate type)
//  You may also get creative and create a new method that takes a parameter that is
//  of the interface type (as opposed to a loop.)
//  Any usage of the classes via their interface is a success!

namespace DoinSomeMath
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (var arg in args)
            {
                var sum = new Sum();
            }
        }
    }
}
