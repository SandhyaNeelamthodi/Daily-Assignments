//Write a program in C# Sharp to print individual characters of the string in reverse order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i;
            Console.WriteLine("enter the string: ");
            
            str = Console.ReadLine();
            i = str.Length - 1;
            while (i>=0)
            {
                Console.Write(str[i]);
                i--;
            }
            Console.WriteLine("\n\n");


        }
    }
}
