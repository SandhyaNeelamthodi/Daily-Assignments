using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n; 
                int Sum=0;
             
            double avg;
            Console.WriteLine("enter value of n");
            n = int.Parse(Console.ReadLine());
            for (i=0; i<n;i++)
            {
                Sum = Sum + i;
                


            }
            
            avg = Sum / n;
            Console.WriteLine("sum of numbers is{0} \n the average is {1}",Sum, avg);

        }
    }
}
