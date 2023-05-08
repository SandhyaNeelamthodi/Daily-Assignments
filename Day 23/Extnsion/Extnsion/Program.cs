using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extnsion
{
    public static  class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool result=i.IsGreaterThan(100);
            Console.WriteLine(result);
        }
        public static bool IsGreaterThan(this int i, int value) 
        {
            return i > value;
        }
    }
}
