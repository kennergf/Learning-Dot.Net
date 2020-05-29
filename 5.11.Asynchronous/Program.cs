using System;
using System.IO;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString());
            SayHelloAsync();
            SayHiAsync();
            CreateFileAsync("teste.txt");

            // SayHello().Wait();
            // SayHi().Wait();

            Console.ReadKey();
        }

        public static async Task SayHelloAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Hello");
            Console.WriteLine(DateTime.Now.ToString());
        }

        public static async Task SayHiAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Hi");
            Console.WriteLine(DateTime.Now.ToString());
        }

        public static async Task CreateFileAsync(string fileName)
        {
            using(StreamWriter writer = File.CreateText(fileName))
            {
                await writer.WriteAsync(DateTime.Now.ToString());
            }
        }
    }
}
