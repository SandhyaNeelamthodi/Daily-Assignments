using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Anonymous
{
    internal class Program
    {
        public delegate int Add(int i,int j);
        static void Main(string[] args)
        {
            int result;
            Add a = delegate (int b, int c)
            {
                return b + c;
            };
            result = a(10, 20);
            Console.WriteLine(result);

           


           
        }
    }
}
