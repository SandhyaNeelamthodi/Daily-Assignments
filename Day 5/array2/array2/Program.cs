using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter the array elements"); 
            for(int i=0;  i<5; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
              
            }
            int min = a[0];
            int max = a[0];
            for( int i=1; i<5; ++i )
            {
                if (a[i] > max )
                    max= a[i];
                if (a[i] < min)
                    min= a[i];
            }
            Console.WriteLine($"The minimum number is {min}and max number is {max}");
        }
    }
}
