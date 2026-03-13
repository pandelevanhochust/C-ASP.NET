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
    
    public static void Main(string[] args)
    {
        try
        {

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
            string s = " aaaa";
            s.Print();

            Product prod = new Product("ame");
            prod = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.Read();

            int a = 5;
            int b = 1;
            int c = a - b;

            if (b == 0)
            {
                // Exception e = new Exception("ra khong roi");
                throw new CustomException();
            }
            if (c < 10)
            {
                throw new NumberException(c);
            }
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
