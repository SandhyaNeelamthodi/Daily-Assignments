using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=int.Parse(Console.ReadLine());
            int[] arr=new int[num];
            while (num > 0)
            {

                int rem = num % 2;

                num /= 2;

                Console.Write(rem);



            }



            
            

        }
    }
}
