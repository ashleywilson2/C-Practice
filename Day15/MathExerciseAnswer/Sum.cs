using System;
using System.Collections.Generic;
using System.Text;

namespace MathExerciseAnswer
{
    public class Sum : AggregateFunction
    {
        public override int Calculate()
        {
            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

      
    }
}
