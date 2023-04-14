using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Emp e1 = new Emp();
            Emp e2 = new Emp(1,"Sandhya",30000);
            Console.WriteLine("enter employee Id:");
            e1.EmpId=int.Parse(Console.ReadLine());
            
            Console.WriteLine("enter employee name:");
            e1.Name=Console.ReadLine();
            
            Console.WriteLine("enter employee salary:");
            e1.Salary=decimal.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine(e2.EmpId);
            Console.WriteLine(e2.Name);
            Console.WriteLine(e2.Salary);
        }
    }
}
