using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list = new List<Song>();
            Console.WriteLine("Enter the number of Songs:");
            int n=int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[]s=Console.ReadLine().Split(',');
                
                
                
                DateTime dt = DateTime.Parse(s[3]);
                double d = double.Parse(s[4]);
                int nd = int.Parse(s[5]);
                Song s1= new Song(s[0], s[1], s[2], dt,d,nd);
                list.Add(s1);
            }
            SortedDictionary<string, int> sd1 = new SortedDictionary<string, int>();
            sd1= Song.CalculateTypeCount(list);
            Console.WriteLine("SongType \t Count");
            foreach(var item in sd1)
            {
                Console.WriteLine(item.Key+"\t\t"+item.Value);
            }
        }
    }
}
