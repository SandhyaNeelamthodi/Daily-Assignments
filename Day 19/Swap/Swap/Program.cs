using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of a:");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b:");
            int b=int.Parse(Console.ReadLine());
            List<int> li = new List<int>();
            li=get(a,b);
            foreach (int i in li)
            {
                Console.WriteLine($"{i}");
            }

        }
        public static List<int> get(int a, int b)
        {
            List<int> c = new List<int>();
            c.Add(b);
            c.Add(a);
            
            return c;
            
            
        }
    }
}
