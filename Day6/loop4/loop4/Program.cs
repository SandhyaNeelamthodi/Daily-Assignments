//nested loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)

                {
                    Console.Write(i);

                }
                Console.WriteLine();
            }
            
        }
    }
}
