using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s =new SortedList();
            s.Add("Maharashtra ", "Mumbai");
            s.Add("Karnataka" ,"Banglore");
            s.Add("TmailNadu", "Chennai");
            Console.WriteLine("elements in sorted list");
           foreach (var item in s.Keys)
           {
               Console.WriteLine(item);
            }
            Console.WriteLine("");
            foreach(var item in s.Values)
            {
                Console.WriteLine(item);
            }

        }
        
    }
}
