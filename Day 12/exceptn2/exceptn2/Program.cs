using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b ;
            int[] a= new int[5];
            try
            {
                b=int.Parse(Console.ReadLine());
                int i = 10 / b;
                a[10] = 9;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DIVIDE BY ZERO ERROR");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bound");
            }
            finally
            {

                Console.WriteLine("finally");
            }
        }
    }
}
