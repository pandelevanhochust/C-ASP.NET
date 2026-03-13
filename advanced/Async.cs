using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced
{
    public class Async
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task DoSomethingAsync(int seconds, string msg)
        {
            for (int i = 1; i <= seconds; i++)
            {
                Console.WriteLine($"{msg} {i}");
                await Task.Delay(1000);
            }
        }

        public static async Task<string> FetchUrl(string url)
        {

            string body = await client.GetStringAsync(url);
            return body;
        }

    }
}
