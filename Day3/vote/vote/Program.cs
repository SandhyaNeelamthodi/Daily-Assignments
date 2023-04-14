using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int age=0;
             Console.WriteLine("enter your age:");
             age= int.Parse(Console.ReadLine());
             string b;
             b = check(age);
             Console.WriteLine(b);


         }
         public static string check(int age)
         {


             if (age>=18)
             {
                 return ("eligible");
             }
             return ("not eligible"); 
            /* in the form of true/false
            int age;
            Console.WriteLine("enter your age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age >= 18); */


        }
    }
}
