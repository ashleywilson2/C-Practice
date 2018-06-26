using System;

namespace Jackie
{
    class Program
    {
        static void Main(string[] args)
        {
            var spot = new Animals("Spot", 5);
            var gary = new Animals("Gary", 15);

            Console.WriteLine(spot.GetSpeech());
            Console.WriteLine(gary.GetSpeech());
            Console.ReadKey();
        }
    }
}
