using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace advanced
{
    public class Finalizer:IDisposable
    {
        public bool resource = true;
        public void Dispose()
        {
            Console.WriteLine("The end");
            resource = false;
        }
    }
}