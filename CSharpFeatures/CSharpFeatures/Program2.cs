using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    class Program2
    {
        
        public static Task<string> Send()
        {
            return Task.Run(() =>
            {                
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Send!");
                return "Nachricht gesendet";

            });
        }

        public static async Task<bool> RunAsync()
        {
            Console.WriteLine("Start Send");
            var result = await Send();
            Console.WriteLine(result);
            Console.WriteLine("End Send");           
            return true;
        }
              
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            RunAsync();
            Console.WriteLine("-----------");
            Console.ReadLine();
        }
    }
}