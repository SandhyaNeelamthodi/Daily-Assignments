//print series of even numbers between 1 & 100
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n ;
            Console.WriteLine("enter n1");
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

        }
    }
}
