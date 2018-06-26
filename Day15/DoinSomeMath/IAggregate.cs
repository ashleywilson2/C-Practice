using System;
using System.Collections.Generic;
using System.Text;

namespace DoinSomeMath
{
    public interface IAggregate
    {
        void Add(int value);
        int Calculate();
    }
}
