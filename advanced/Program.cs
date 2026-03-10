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
}

public class Program
{

    public static void Main(string[] args)
    {
        try
        {
            double x = 5.5.PowerTwo();
            7.5.Square();
            string s = " aaaa";
            s.Print();

            Product prod = new Product("ame");
            // prod = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("End of Main");
            int a = 5;
            int b = 0;
            int c = a / b;

            if (b == 0)
            {
                Exception e = new Exception("ra khong roi");
                throw e;
            }
        }
        catch (DivideByZeroException e) // 
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Khong chia het");
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
