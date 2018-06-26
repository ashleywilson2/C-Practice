using System;
using System.Collections.Generic;
using System.Text;

namespace MathExerciseAnswer
{
    public abstract class AggregateFunction : IAggregate
    {
        protected readonly List<int> numbers = new List<int>();

        public abstract int Calculate();

        public void Insert(int value)
        {
            numbers.Add(value);
        }

    }
}
