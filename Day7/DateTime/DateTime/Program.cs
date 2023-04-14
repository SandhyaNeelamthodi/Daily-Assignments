using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);
            DateTime d = new DateTime(2015,12,31);
            Console.WriteLine(d);
            TimeSpan ts = new TimeSpan(25,20,55);
            Console.WriteLine(ts);
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine(todaysDate);
            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUTC);
        }
    }
}
