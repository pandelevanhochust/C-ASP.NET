using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced
{
    public class Async
    {
        public static async Task DoSomethingAsync(int seconds, string msg)
        {
            for (int i = 1; i <= seconds; i++)
            {
                Console.WriteLine($"{msg} {i}");
                await Task.Delay(1000);
            }
        }
    }
}
