using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
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

        static async Task Main(string[] args)
        {
            Console.WriteLine("-----------");
            await RunAsync();
            Console.WriteLine("-----------");
            Console.ReadLine();
        }
    }
}



// async within main: 
// var result = RunAsync().Result;
// RunAsync().GetAwaiter().GetResult();