using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace n_and51
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n, diff;
            const int x = 51;
            Console.WriteLine("enter the value of n:");
            n=int.Parse(Console.ReadLine());
            diff=DiffC(n,x);
            Console.WriteLine(diff);

        }
        static int DiffC(int n, int x)
        {
            int diff;
            diff = n - x;
            if (n > x)
            {
                return (n - x) * 3;

            }
            
                return (x - n);
           
        }
    }
}
