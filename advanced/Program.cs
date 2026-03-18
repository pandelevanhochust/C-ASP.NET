using System.Runtime.InteropServices.Marshalling;
using System.Security.Authentication.ExtendedProtection;
using advanced;

namespace Advanced;

static class Abc
{
    public static void Print(this string s, ConsoleColor color = ConsoleColor.Cyan)
    {
        ConsoleColor lastColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(s);
        Console.ForegroundColor = lastColor;
    }

    public static void Render<T>(this IEnumerable<T> li)
    {
        foreach (var i in li) Console.Write(i + " ");
        Console.WriteLine();
    }

}

public class Program
{


    public static void DoSomething(int seconds, string mgs)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.WriteLine($"{mgs} {i}");
            Thread.Sleep(1000);
        }
    }

    public static void PintInfo(string info) =>
        Console.WriteLine($"{info,10}    task:{Task.CurrentId,3}    " +
                          $"thread: {Thread.CurrentThread.ManagedThreadId}");

    public static void RunTask(int i)
    {
        PintInfo($"Start {i,3}");
        Task.Delay(5000).Wait();
        PintInfo($"Finish {i,3}");
    }

    public static void ParallelFor()
    {
        ParallelLoopResult result = Parallel.For(1, 20, RunTask);
        Console.WriteLine($"All task start and finish: {result.IsCompleted}");
    }

    public record PointClass(int X, int Y); // record class (by default, is reference )
    public record struct PointStruct(int X, int Y);


    public static async Task Main(string[] args)
    {

        Cars.PrintProductionStats(); // Output: 0
        Cars car1 = new Cars("Toyota Corolla");
        // Access through instance method. Output: "Car model: Toyota Corolla"
        car1.PrintModel();
        // Access through static method. Output: 1
        Cars.PrintProductionStats();

        
        var p1 = new PointClass(1, 2);
        // p1.X = 5; // ERROR: X is init-only!

        var p2 = new PointStruct(1, 2);
        p2.X = 5; // PERFECTLY FINE. p2 is now (5, 2)


        try
        {

            int? xx = 10;
            Console.WriteLine(xx ?? 11);

            string s = "hihi";
            char s1 = s[2];
            Console.WriteLine(s1);

            DepenencyInjection di = new DepenencyInjection();
            di.Honky();

            string url = "https://jsonplaceholder.typicode.com/todos/4";
            // Async.DoSomethingAsync(5, "Hello, async world!").Wait();    
            // var result = Async.FetchUrl(url).Result;
            // Console.WriteLine(result);

            // ParallelFor();

            DoSomething(5, "Hello, world!");

            List<int> li = [101, 2, 3, 4, 5];
            li.Add(4);
            li.Remove(5);
            Console.Write("Contains: " + li.Contains(1)); // True
            li.Sort();
            // li.Clear();
            li.Render();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "banana");
            dict.Add(2, "apple");
            dict.ContainsKey(1); // True
            dict.Remove(1);

            string value;
            dict.TryGetValue(2, out value); // value = "apple"
            Console.WriteLine(value);
            dict.Render();

            HashSet<int> set = new HashSet<int> { 1, 1, 2, 3, 2, 5 };
            HashSet<int> set2 = new HashSet<int> { 7, 8, 6, 8, 4, 5, 6 };
            set.Add(100);
            set.Remove(1);
            // set.UnionWith(set2); // 1,2,3,4,5,6,7,8,100
            set.IntersectWith(set2); // 5
            set.Render();
            // intersect.Render();


            // using (var db = new DatabaseManager("Server=MyServer;"))
            // {
            //     // Use the database here
            // }
            // // Dispose() is called automatically HERE

            double x = 5.5.PowerTwo();
            7.5.Square();
            s.Print();

            Product prod = new Product("ame");
            prod = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.Read();
        }
        // catch (DivideByZeroException e) // 
        // {
        //     Console.WriteLine(e.Message);
        //     Console.WriteLine("Khong chia het");
        // }
        catch (CustomException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NumberException e)
        {
            e.Report();
        }
        catch (Exception e) // Exception is the "Grandfather" of all exceptions. It catches everything.
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            Console.WriteLine("Hello");
        }
    }
}
