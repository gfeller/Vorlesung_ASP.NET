using System;
using System.Dynamic;

namespace DynamicObject
{
    class Program
    {
        public static dynamic CreateUser(string name)
        {
            dynamic person = new ExpandoObject();
            person.SayHi = new Action(() => Console.WriteLine(person.Name));
            person.Name = name;
            return person;
        }

        static void Main(string[] args)
        {
            dynamic person = CreateUser("Michael");
            person.SayHi();

            person.GivenName = "Gfeller";
            person.SayHi = new Action(() => Console.WriteLine(person.Name + " " + person.GivenName));
            person.SayHi();
            Console.ReadLine();
        }
    }
}