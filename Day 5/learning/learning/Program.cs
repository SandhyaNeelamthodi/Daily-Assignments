using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*implicit
            int cs = 9;
            double ds = cs;
            Console.WriteLine(ds);
            //explicit
            int A = 1345;
            double B = (double) A;
            Console.WriteLine(B);    */
            //Console.WriteLine("entr age");
            //int age = Convert.ToInt32(Console.ReadLine());
            string str = "ti hello";
            int a=str.IndexOf("h");
            string x=str.Substring(a);
            Console.WriteLine(x);
           // Console.WriteLine(str.IndexOf('i'));

        }
    }
}
