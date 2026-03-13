using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace advanced
{
    public class CustomException : Exception
    {
        public CustomException() : base("khong ten") { }
    }

    public class NumberException : Exception
    {
        public int v{set; get;}
        public NumberException(int value) : base($"sai loi o so {value}")
        {
            v = value;
        }

        public void Report()
        {
            Console.WriteLine($"Cause at number + {v}");
        }
    }
}