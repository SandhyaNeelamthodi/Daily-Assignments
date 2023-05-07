using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = new List<Song>
            {
                new Song("ShapeOfYou","Edsheeran","Pop",4.8,12000,DateTime.Parse("12-07-2017")),
           new Song("Perfect","Edsheeran","Pop",4.5,120500,DateTime.Parse("06-08-2017")),
           new Song("Mercy","Shawn Mendes","Jazz",4.6,50000,DateTime.Parse("03-09-2017"))
            };
            

            //Console.WriteLine("Name\t\t Artist\t\tSong Type\t\tNo of Downloads\t\tRating\t\tDate Downloaded");

            foreach (Song s in ls)

            {

                Console.WriteLine(s);

            }

            Console.WriteLine();

            ls.Sort();

            Console.WriteLine("Sorted Song List on Name");

            foreach (Song s in ls)
            {



                Console.WriteLine(s);
            }
            Console.WriteLine();

            ls.Sort(new RatingComparer());

            Console.WriteLine("Sorted Song List on Rating");

            foreach (Song s in ls)
            {

                Console.WriteLine(s);
            }

        }
    }
    
}
