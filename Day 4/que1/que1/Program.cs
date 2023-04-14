using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            bool test;
            Console.WriteLine("enter the first number:");
            n1= int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number:");
            n2= int.Parse(Console.ReadLine());
            test=test1(n1,n2);
            Console.WriteLine(test);
        }
        static bool test1( int n1,int n2)
        {
            return n1==30 || n2==30 || (n1+n2==30);

        }
        
            
    }
}
