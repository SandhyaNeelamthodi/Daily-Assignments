using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Add(int i,int j)
        {
            Console.WriteLine("Sum :" + (i + j));
        }
        static void Sub(int i,int j)
        {
            Console.WriteLine("Sub :"+(i-j));
        }
        static void Multiply(int i,int j)
        {
            Console.WriteLine("Multiply:"+(i*j));
        }
        public delegate void reftomethod(int i ,int j);
        static void Main(string[] args)
        {
            /*Add(10, 20);
            reftomethod r1 = Add;
            r1(10,20);
            reftomethod r2=Sub; 
            r2(10,20);)*/
            reftomethod multicast = Add;
            multicast += Sub;
            multicast += Multiply;
            multicast(20, 10);
        }
    }
}
