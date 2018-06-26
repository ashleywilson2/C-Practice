using System;
using Xunit;
using ClassLibrary2;

namespace XUnitTestProject2
{
    public class NameProcessorTests
          
        {
            [Fact]
            public void SwitchesCase()
            {
                var nameProcessor = new NameProcessor();
                nameProcessor.Add("bob");
                nameProcessor.Add("Alice");
                nameProcessor.Add("Bobby");
                nameProcessor.Add("alina");

            var bobs = nameProcessor.GetNamesStartingWith("Bob");
            var alis = nameProcessor.GetNamesStartingWith("Ali");
            var charlies = nameProcessor.GetNamesStartingWith("Charlie");
        }

            
            //public void GetsNames()
            //{
            //    var bobs = nameProcessor.GetNamesStartingWith("Bob");
            //    var alis = nameProcessor.GetNamesStartingWith("Ali");
            //    var charlies = nameProcessor.GetNamesStartingWith("Charlie");
            //}
        }
    
}
