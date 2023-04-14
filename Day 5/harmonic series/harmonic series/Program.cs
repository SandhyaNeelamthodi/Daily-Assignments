//find sum of harmonic series
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmonic_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  i,n;
            
            double sum=0.0;
            Console.WriteLine("enter value of n");
            n=int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                Console.WriteLine("harmonic series is 1/{0}", i);


                sum = sum + (1 / (double)i);
            }
            Console.WriteLine("sum of harmonic {0}", sum);

        }
    }
}
