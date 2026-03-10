using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace advanced
{
    public static class ExtensionMethod
    {
        public static double PowerTwo(this double x) => x*x;
        public static void Square(this double x) => Console.WriteLine(Math.Sqrt(x));
    }
}