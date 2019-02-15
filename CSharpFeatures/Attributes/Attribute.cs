using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
    public class SomeAttribute : Attribute
    {
        public string Name { get; set; }

        public SomeAttribute(string name)
        {
            this.Name = name;
        }
    }

    [Some("Michael")]
    public class Demo
    {

    }

    [Some("Lisa")]
    public class Demo2
    {

    }

    public class Demo3
    {

    }

    public class Runner
    {
        public static void Main(string[] args)
        {
            var demo = new Demo();
            Console.WriteLine(demo.GetType().GetTypeInfo().GetCustomAttribute<SomeAttribute>().Name);
            Console.ReadLine();

            var typesWithAttribute = (from type in Assembly.GetEntryAssembly().GetTypes()
                where type.GetCustomAttribute<SomeAttribute>() != null
                select type).ToList();

            typesWithAttribute.ForEach(x => Console.WriteLine(x.Name));
            Console.ReadLine();
            
            PrintObj(Activator.CreateInstance(typesWithAttribute.First()));
            Console.ReadLine();
        }

        public static void PrintObj(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
