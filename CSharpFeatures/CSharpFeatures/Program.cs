using System;
using System.Dynamic;

namespace CSharpFeatures
{
    class Program
    {
        public static dynamic createUser(string Name)
        {
            dynamic person = new ExpandoObject();
            person.SayHi = new Action(() => Console.WriteLine(person.Name));
            person.Name = "Michael";
            return person;
        }

        static void Main_1(string[] args)
        {
            dynamic person = createUser("Michael");
            person.SayHi();

            person.GivenName = "Gfeller";
            person.SayHi = new Action(() => Console.WriteLine(person.Name + " "+ person.GivenName));
            person.SayHi();
            Console.ReadLine();
        }
    }
}