using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace extnsion2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string s = "India is Great";
            string result = s.myUpper();
            Console.WriteLine(result);
        }
        public static string myUpper(this string s)
        { return s.ToUpper();  }
    }
}
