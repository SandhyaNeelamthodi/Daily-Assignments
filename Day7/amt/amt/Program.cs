using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace amt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amt");
            int amt=int.Parse(Console.ReadLine());
            
            int[] arr = { 2000, 500, 100, 50, 10, 5, 2, 1 };
            {
                for (int i = 0; i <= 8; i++)
                {
                    int n = amt / arr[i];
                    amt = amt % arr[i];
                    Console.WriteLine(n);

                }
                

            }
        }    
    }
}
