using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lilly", "hibiscus", "dafodil" };
            var fQuery=
                from flower in flowers
                where(flower.StartsWith("d"))
                select flower;
            foreach(string f in fQuery)
            {
                Console.WriteLine(f);
            }
            var lQuery = from flower in flowers
                         let len
        }
    }
}
