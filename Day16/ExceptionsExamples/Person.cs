using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionsExamples
{
    public class Person
    {
        public int Age { get; } //public can only GET the value of Age, they can't SET the Age
        public Person(int age) //constructors are Capitalized, arguments are camelCase
        {
            if (age < 0) throw new InvalidAgeException();
            Age = age;
        }
    }
}
