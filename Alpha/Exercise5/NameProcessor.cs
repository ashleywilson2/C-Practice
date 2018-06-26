using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class NameProcessor
    {
        private readonly List<string> people = new List<string>();

        public void Add(string names)
        {
            people.Add(names);
            Char.ToUpper();
        }

        public void GetNamesStartingWith()
        {

        }


    }
}
