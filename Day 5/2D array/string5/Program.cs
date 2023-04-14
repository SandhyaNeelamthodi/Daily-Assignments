using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraytwoD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
                int j=0;
            int[,] a = new int [3,3];
            Console.WriteLine("enter the array elements");
            
            for (i=0; i<3; i++)
            {
                
                for(j=0; j<3; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
                /*Console.WriteLine("matrix is");
                for(i = 0; i<3; i++)
                {
                    Console.WriteLine("\n");
                    for(j=0; j<3;j++)
                    {
                        Console.WriteLine(a[i,j]);
                    }
                }*/
                
            }
        }
    }
}
