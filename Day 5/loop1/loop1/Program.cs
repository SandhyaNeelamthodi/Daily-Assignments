using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,n , sum = 0;
            
            double avg;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements:");
            for (i = 0; i <= 10; i++)
            {
                sum= sum+n;
                    

            }
            avg = sum / 10;
            Console.WriteLine($"the sum of 10 no is {sum}\n the avg is {avg}");
        }
    }
}
