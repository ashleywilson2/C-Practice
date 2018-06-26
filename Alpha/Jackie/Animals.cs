using System;
using System.Collections.Generic;
using System.Text;

namespace Jackie
{
    public class Animals
    {
        private readonly string name;
        private readonly int age;

        public Animals(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetSpeech()
        {
            return $"Bark!  My name is {name}, and I'm {age} years old!";
        }
    }
}
