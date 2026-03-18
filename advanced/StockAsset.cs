using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advanced
{
    public interface IBalanceable
    {
        decimal Worth { get; }
        void PrintStatement();
    }

    public abstract class Asset : IBalanceable
    {
        public string Name { get; init; }

        protected Asset(string name)
        {
            Name = name;
        }
        public abstract decimal Worth { get; }

        public virtual void PrintStatement()
        {
            Console.WriteLine($"{Name} is currently worth: {Worth:C}");
        }
    }

    public class StockAsset : Asset
    {
        private readonly decimal _currentPrice;
        private readonly decimal _sharesOwned;

        public StockAsset(string name, decimal price, decimal shares) : base(name)
        {
            _currentPrice = price;
            _sharesOwned = shares;
        }

        //Overiding methods 
        public override decimal Worth => _currentPrice * _sharesOwned;

        public override void PrintStatement()
        {
            Console.Write("[STOCK] ");
            base.PrintStatement();
        }
    }
}