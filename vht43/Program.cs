using System.Security.Cryptography.X509Certificates;

namespace VHT;

public class Program
{
    public static void Main(string[] args)
    {
        int factor = 10;
        // Func<int,int> invalidStatic = static n => n * factor; //ERROR
        Func<int, int> invalidStatic = static n => n * 5;
        Console.WriteLine(invalidStatic(10));

        // publisher
        UserInput userevent = new UserInput();

        // subscriber
        Square square = new Square();
        square.Sub(userevent);

        Plus plus = new Plus();
        plus.Sub(userevent);

        Console.CancelKeyPress += (sender, e) => Console.WriteLine("hellpo");

        // Input
        userevent.Input();

        Stock stock = new Stock("stock");
        stock.Price = 27.10M;
        stock.PriceChanged += stock_PriceChanged;
        stock.Price = 40.1M;

        // stock.StockInput();

        void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }

    }

    delegate int Test(int x);
}