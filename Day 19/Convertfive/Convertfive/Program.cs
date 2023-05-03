using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Convertfive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int r;
            //    Console.WriteLine("enter the value of n");
            //    int n = int.Parse(Console.ReadLine());
            //    r = ConvertFive(n);
            //    Console.WriteLine(r);
            //}
            //static int ConvertFive(int n)
            //{

            //    string str = n.ToString();
            //    string s = str.Replace('0', '5');

            //    return Convert.ToInt32(s);
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            string n = a.ToString();
            string s = n.Replace('0', '5');
            Console.WriteLine("the no.is" + s);
        }
    }
}
