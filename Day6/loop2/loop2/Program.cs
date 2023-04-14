using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 , n2 =0 ;
            int max, min;
            Console.WriteLine("enter n1");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2=int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                max= n1;
                min= n2;
               
            }
            else
            {
                min = n1;
                max = n2;
            }
            for(int i=min;i<=max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
