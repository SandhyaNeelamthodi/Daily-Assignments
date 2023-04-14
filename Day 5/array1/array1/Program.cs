using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a=new int[5];
            int i = 0; 
            int sum=0;
            Console.WriteLine("Enter the array elements");
            
            for(i=0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<a.Length;i++)
            {
                sum += a[i];
            }
            
            Console.WriteLine($"sum of array elements is {sum}");
        }
        
    }
}
