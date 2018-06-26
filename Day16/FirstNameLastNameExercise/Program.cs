using System;

//Exercise:
//  Create a lambda function that takes first and last names and putputs them as Last Name, First Name

namespace FirstNameLastNameExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //My answer:
            Func<string, string, bool> names = (f, l) =>
            {
                Console.WriteLine(l + ", " + f);
                return true;
            };
            names("Ashley", "Wilson");
            names("Justin", "Platt");

            //Dereck's answer:
            Func<string, string, string> getFullName = (fname, lname) =>
            {
                return $"{lname}, {fname}"; //string interpolation
            };

            //Typing in someone's name into the console and then displaying the results through the func:
            Console.WriteLine("Please enter the first name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name: ");
            var lastName = Console.ReadLine();
            var fullName = getFullName(firstName, lastName);
            Console.WriteLine("Full Name: ");
            Console.WriteLine(fullName);

            Console.ReadKey();
        }
    }
}
