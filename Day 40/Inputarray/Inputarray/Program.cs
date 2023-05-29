using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inputarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of array");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements of array");
            int[] a = new int[n];
            for (int i=0; i<n; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
                
            }
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
