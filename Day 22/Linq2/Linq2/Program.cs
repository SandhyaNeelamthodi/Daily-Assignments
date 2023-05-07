using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Emp> Emplist = new List<Emp>();
         Emplist.Add(new Emp("Ram","Delhi"));
         Emplist.Add(new Emp("Shyam","Delhi"));
            Emplist.Add(new Emp("Lal","Tvm"));
            Emplist.Add(new Emp("Amit","Kolkatta"));
            Emplist.Add(new Emp("Aman","Pattambi"));
            var fQuery = from Emp Employee in Emplist
                         orderby Employee.City
                         group Employee by Employee.City;

            foreach(var f in fQuery)
            {
                Console.WriteLine(" Employee with " + f.Key + " City ");
                foreach(var e in f)
                { Console.WriteLine("" + e.Name); }
            }
            
            
        }
        
    }
}
