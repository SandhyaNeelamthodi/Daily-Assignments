﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousdemo
{
    internal class Program
    {
        delegate void CountIt();
        static void Main(string[] args)
        {
            CountIt count = delegate
            {



                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            };
            count();
            

        }
    }
}
