using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 10,i;
            

            try
            {
                i = int.Parse(Console.ReadLine());
                k = k / i;


             
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("hello");
            }

        }
    }
}
