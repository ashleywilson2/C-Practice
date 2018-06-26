using System;
using Xunit;
using ClassLibrary;

namespace XUnitTestProject1
{
    public class AdderTests
    {
        [Fact]  //this is an attribute on a method - tells the unit test framework to run the following method as a test:
        public void CalculatesCorrectly()
        {
            var adder = new Adder();
            adder.Add(1);
            adder.Add(2);
            adder.Add(3);
            var result = adder.Calculate();

            Assert.Equal(6, result);
        }
    }
}
