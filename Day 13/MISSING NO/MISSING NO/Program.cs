using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISSING_NO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] a = { 1, 2, 4, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == i)
                {
                    Console.WriteLine($"Missing element is{a[i]}");
                }
            }*/
            int[] a = { 1, 2, 4, 5 };

            int sum1 = 0;

            for (int i = 0; i < a.Length; i++)

            {

                sum1 = sum1 + a[i];

            }

            Console.WriteLine(sum1);

            int sum2 = 0;

            for (int i = 1; i <= 5; i++)

            {

                sum2 = sum2 + i;

            }

            Console.WriteLine("sum of range of elements " + sum2);

            Console.WriteLine("Missing number is " + (sum2 - sum1));

        }
    }
    
}
