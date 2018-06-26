using System;
using System.Collections.Generic;
using System.Text;

namespace MathExerciseAnswer
{
    public interface IAggregate
    {
        void Insert(int value);
        int Calculate();
    }
}
