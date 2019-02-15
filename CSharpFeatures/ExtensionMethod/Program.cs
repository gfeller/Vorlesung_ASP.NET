using System;

namespace ExtensionMethod
{

    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }).Length;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Extension Methods".WordCount());
            Console.ReadLine();
        }
    }
}
