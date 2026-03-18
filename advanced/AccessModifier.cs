using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advanced
{
    public class FinancialAsset
    {
        public string Name = "Generic Asset";      // Visible to everyone
        protected decimal TaxRate = 0.15m;         // Visible only to this class and its children
        private string _secretKey = "XY-123";      // Visible ONLY inside this class
        internal string Location = "New York";     // Visible to any code in this same project
    }
    // Child Class (Inheritance)
    public class Stock : FinancialAsset
    {
        public void PrintDetails()
        {
            // 1. PUBLIC
            Console.WriteLine($"Name: {Name}");
            // 2. PROTECTED
            Console.WriteLine($"Tax: {TaxRate * 100}%");
            // 3. INTERNAL
            Console.WriteLine($"Market: {Location}");
            // 4. PRIVATE
            // Console.WriteLine(_secretKey); 
        }
    }

    public class Cars
    {
        private static int totalCarsProduced = 0;
        public string Model { get; set; }

        // Constructor: Runs every time we use the 'new' keyword
        public Cars(string modelName)
        {
            Model = modelName;
            // Every time a new car is built, we increase the global counter.
            totalCarsProduced++;
        }

        // 1. PUBLIC METHOD
        public void PrintModel() =>  Console.WriteLine($"Car model: {Model}");

        // 3. STATIC METHOD
        public static void PrintProductionStats() =>
        Console.WriteLine($"Total cars produced in the factory: {totalCarsProduced}");
        
    }
}