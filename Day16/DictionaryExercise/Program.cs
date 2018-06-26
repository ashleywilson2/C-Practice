using System;
using System.Collections.Generic;

//Exercise: play around with dictionaries and nesting them

namespace DictionaryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, LineDanceSpecs>();
            dictionary.Add("Tush Push", new LineDanceSpecs()
            {
                SongTitle = "Chatahoochie",
                DanceTitle = "Tush Push",
                Difficulty = "Intermediate",
                TagsRestarts = false
            });
            dictionary.Add("Tush Push", new LineDanceSpecs()
            {
                SongTitle = "Cold Beer",
                DanceTitle = "Tush Push",
                Difficulty = "Intermediate",
                TagsRestarts = false
            });

            Console.ReadKey();
        }
    }
}
