﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatedemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}*/
using System;
using System.Data;
namespace Delegatedemo
{
    delegate void Print();

    class Money

    {

        protected uint note;

        protected uint coin;

        public Money(uint n, uint c)

        {

            this.note = n;

            this.coin = c;

        }
        class Rupee : Money

        {

            public Rupee(uint rupees, uint paise) : base(rupees, paise) { }

            public void Display()

            {

                Console.WriteLine("Rs. {0}.{1}", note, coin);

            }

        }

        class Dollar : Money

        {

            public Dollar(uint dollar, uint cent) : base(dollar, cent) { }

            public void Info()

            {

                Console.WriteLine("${0}.{1}", note, coin);

            }

        }

        class Test

        {

            static void Main()
            {
                Rupee m1 = new Rupee(1000, 55);

                Dollar m2 = new Dollar(100, 75);

                Print[] p = new Print[2];

                p[0] = new Print(m1.Display);

                p[1] = new Print(m2.Info);

                write(p);

            }

            static void write(Print[] p)

            {

                p[0]();

                p[1]();

            }

        }
    }
}