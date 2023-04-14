using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, j;
            Console.WriteLine("MULTIPLICATION TABLE");
            
            Console.WriteLine("Input the number:");
            n = int.Parse(Console.ReadLine());
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("{0}*{1}={2}", j, n,n*j);
            }
        }
    }
}
