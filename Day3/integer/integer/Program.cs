using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, sum;
            Console.WriteLine("enter first integer:");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter second integer:");
            n2=int.Parse(Console.ReadLine());
            sum = sumInt(n1, n2);
            Console.WriteLine(sum);

        }
        static int sumInt(int n1, int n2)
        {
            int sum;
            sum = n1 + n2;
            {
                if(n1==n2)
                {
                    return (sum) * 3;
                }
                return (n1 + n2);
            }
        }
    }
}
