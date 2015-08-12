using MyMemoryApi;
using MyMemoryApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMemoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Task demo=Demo();
            demo.Wait();
        }

        private static async Task Demo()
        {
            GetResponse response=await MyMemory.GetAsync("Hello", "en|pl");
            foreach(GetMatch m in response.Matches)
            {
                Console.WriteLine(m.Translation);
            }
            Console.ReadLine();
        }
    }
}
