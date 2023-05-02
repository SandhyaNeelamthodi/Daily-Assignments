using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*ArrayList a = new ArrayList();
            Console.WriteLine("Enter the elements");
            for(int i=1; i<=N; i++)
            {
                i = int.Parse(Console.ReadLine());
                a.Add(i);
                
                
            }*/
            int[] arr = { 1,2,3,7,5 };

            int n = 5;

            int sum = 0;

            subArraySum(arr, n, sum);



        }
        public static void subArraySum(int[] arr, int n, int sum  )
        {
            int S = 12;
            for(int i = 0; i < n; i++)
            {
               
                sum = arr[i];
                for(int j=i+1; j<n; j++)
                {
                    sum+= arr[j];
                    if (sum == S)
                    {
                        Console.WriteLine($"sum found at starting index{i} and ending index{j}");
                    }
                    else if (sum > S)
                        break;
                }

                  

            }
            
            
        }
    }
}
