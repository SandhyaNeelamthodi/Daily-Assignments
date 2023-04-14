//Write a program in C# Sharp to separate the individual characters from a string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            Console.WriteLine("enter the string:");
            str= Console.ReadLine();
            Console.WriteLine("characters of the string are:");
               while(l<=str.Length-1)
               {
                Console.Write(" {0} ", str[l]);
                l++;
                }
                Console.WriteLine();
        }
    }
}
