using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    internal class Program
    {
        private static int k;

        static void Main(string[] args)
        {
            int sum = 0;
            int i= 0;
            int n = 2;
            int k = 0;
            Console.WriteLine("Enter the value:");
            k=int.Parse(Console.ReadLine());    
            while (i < k)
            {
                 if(Prime(n))
                {
                    sum += n;
                    
                    i++;
                }
                 n++;
            }
            
            Console.WriteLine($"sum of prime numbers{sum}");

            

        }
        public static bool Prime(int n)
        {
            
            for(int j = 2; j < n; j++)
            {
                if (n % j == 0)
                    return false;
            }
            return true;
        }
    }
}
