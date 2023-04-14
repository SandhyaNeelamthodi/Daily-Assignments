using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the no.of rows:");
            n=int.Parse(Console.ReadLine());
            for(int i = 1; i <= n;i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                    for(int k = 1; k <= 2*i-1;k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("\n");
                
               
            }
        }
    }
}
