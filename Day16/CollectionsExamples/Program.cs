using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListExample();
            //DictionaryExample();
            //QueueExample();
            StackExample();

            Console.ReadKey();
        }

        static void ListExample()
        {
            var list = new List<Pets>();
            list.Add(new Pets()
            {
                //Autoinitialize properties in here
                Name = "Jeff",
                Age = 13,
                IsSpotted = true,
                Color = "Black and White"
            });
            list.Add(new Pets()
            {
                //Autoinitialize properties in here
                Name = "Loretta",
                Age = 3,
                IsSpotted = false,
                Color = "Brown"
            });
            foreach (var pet in list)
            {
                if (pet.Name == "Loretta")
                {
                    Console.WriteLine("Found Loretta!  Her age is:" + pet.Age.ToString());
                }
                Console.WriteLine(pet.Name);
            }
        }

        static void DictionaryExample()
        {
            var dictionary2 = new Dictionary<string, Dictionary<int, Pets>>(); //nested dictionary example
            var pet = new Pets() //putting Tika into the nested dictionary
            {
                Name = "Tika",
                Age = 1,
                IsSpotted = true,
                Color = "Black and White"
            };
            var nestedDictionary = new Dictionary<int, Pets>()
            {
                { pet.Age, pet },
                { 17, new Pets() }
            };
            dictionary2.Add(pet.Name, nestedDictionary);
            var tika = dictionary2["Tika"][1]; //pulls Tika back out of dictionary, used to pull a single pet out that has the same "name" value

            var dictionary = new Dictionary<string, Pets>(); //normal dictionary example

            dictionary.Add("Jeff", new Pets()
            {
                Name = "Jeff",
                Age = 13,
                IsSpotted = true,
                Color = "Black and White"
            });
            dictionary.Add("Loretta", new Pets()
            {
                Name = "Loretta",
                Age = 3,
                IsSpotted = false,
                Color = "Brown"
            });

            var loretta = dictionary["Loretta"];

           
            Console.WriteLine("Found " + loretta.Name + "! Age:" + loretta.Age.ToString());
        }

        static void QueueExample()
        {
            //var jeff = new Pets() { Name = "Jeff" };
            //var loretta = new Pets() { Name = "Loretta" };
            //var tika = new Pets() { Name = "Tika" };

            //var queue = new Queue<Pets>();
            //queue.Enqueue(jeff);
            //queue.Enqueue(loretta);
            //queue.Enqueue(tika);

            var queue = new Queue<Pets>();
            for (var i = 0; i < 100; i++) //looping through an Enqueue
            {
                var newPet = new Pets()
                {
                    Name = "Pet" + i.ToString("00")
                };
                queue.Enqueue(newPet);
            }

            while(queue.Count > 0) //looping through a Dequeue and displaying the results on the console
            {
                var pet = queue.Dequeue();
                Console.WriteLine(pet.Name);
            }

        }

        static void StackExample()
        {
            var jeff = new Pets() { Name = "Jeff" };
            var loretta = new Pets() { Name = "Loretta" };
            var tika = new Pets() { Name = "Tika" };

            var stack = new Stack<Pets>();
            stack.Push(jeff);
            stack.Push(loretta);
            stack.Push(tika);

            while (stack.Count > 0)
            {
                var pet = stack.Pop();
                Console.WriteLine(pet.Name);
            }
        }


    }
}
