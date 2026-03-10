using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advanced
{
    public class Product
    {
        private string product_name;
        public Product(string name)
        {
            this.product_name = name;
            Console.WriteLine("Tạo - " + product_name);
        }

        ~Product() // finalizer
        {
            Console.WriteLine("Goodbye");
        }
    }
}