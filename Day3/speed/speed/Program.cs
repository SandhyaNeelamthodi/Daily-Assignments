using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance=0.0, time;
            Console.WriteLine("enter the distance:");
            distance = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the time:");
            time = double.Parse(Console.ReadLine());
            double speedkm=speed1(distance,time);
            double speedmile=speed2(distance,time);
            Console.WriteLine("speed in km/hr is{0}",speedkm);
            Console.WriteLine("speed in mile/hr is{0}",speedmile);



        }
        static double speed1(double distance,double time)
        {
            return distance*time;
        }
        static double speed2(double distance,double time)
        {
            return (distance * time) / 1.6;
        }


    }
}
