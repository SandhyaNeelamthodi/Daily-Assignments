using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result;
            Console.WriteLine("enter a no:");
            int n=int.Parse(Console.ReadLine());
            result = ArmstrongNo(n);
            Console.WriteLine(result);

        }
        static string ArmstrongNo(int n)
        {
            int a = n;
            int b = 0;
                int temp = 0;

            while(n> 0)
            {
                temp = n % 10;
                b = (int)(b + Math.Pow(temp, 3));
                n = n / 10;
            }
            if (a == b)
            {
                return "yes";

            }
            else
            {
                return "no";
            }
        }
    }
}
