using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candle
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Enter the number:");

            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)

            {

                arr[i] = int.Parse(Console.ReadLine());

            }

            int pos_count = 0;

            int neg_count = 0;

            int zero_count = 0;

            for (int i = 0; i < n; i++)

            {

                if (arr[i] == 0)

                {

                    zero_count++;

                }

                else if (arr[i] > 0)

                {

                    pos_count++;

                }

                else if (arr[i] < 0)

                {

                    neg_count++;

                }

            }

            double pos_ratio = (double)pos_count / n;

            double neg_ratio = (double)neg_count / n;

            double zero_ratio = (double)zero_count / n;

            Console.WriteLine(pos_ratio.ToString("F6"));

            Console.WriteLine(neg_ratio.ToString("F6"));

            Console.WriteLine(zero_ratio.ToString("F6"));

        }

    }

}

