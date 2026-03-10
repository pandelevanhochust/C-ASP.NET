using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VHT
{
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }

    public class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol) => this.symbol = symbol;

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }

        public void StockInput()
        {
            do
            {
                Console.Write("Insert number of stock");
                string value = Console.ReadLine();
                int num = Int32.Parse(value);
                this.Price = num;
            } while (true);
        }
    }
}