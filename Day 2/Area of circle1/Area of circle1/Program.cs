using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_circle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double area;
            Console.WriteLine("Enter the value of radius: ");
            radius= int.Parse(Console.ReadLine());
            area=Math.PI *radius *radius;
            Console.WriteLine("Area of the circle is: " +area);


        }
    }
}
