using System;
using System.Collections.Generic;
using System.Text;

namespace DoinSomeMath
{
    public class Sum : IAggregate
    {
        private readonly List<int> numbers = new List<int>();
        public void Add(int value)
        {
            numbers.Add(value);
        }

        public int Calculate()
        {
            var total = 0;
            foreach (var value in numbers)
            {
                total += value;
            }
            return total;
        }
    }
}
