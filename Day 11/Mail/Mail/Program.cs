using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail> li = new List<Mail>();

            for (int i = 0; i < 2; i++)

            {

                Console.WriteLine("Enter Mail{0} detail", i + 1);

                string[] s = Console.ReadLine().Split(',');

                Mail m = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "MM-dd-yyyy",null), double.Parse(s[6]));

                li.Add(m);

            }

            int j = 1;

            foreach (var item in li)

            {

                Console.WriteLine("mail{0}", j);

                Console.WriteLine(item.ToString());

                j++;

            }

            if (li[0].Equals(li[1]))

            {

                Console.WriteLine("Mail 1 is same as Mail2");

            }

            else

            {

                Console.WriteLine("Mail 1 is not same as Mail2");

            }





        }

        /* private static Mail GetM1(string[] mail1)
         {
             return new Mail(long.Parse(mail1[0]), mail1[1], mail1[2], mail1[3], mail1[4], Convert.ToDateTime(mail1[5]),
                           Convert.ToDouble(mail1[6]));
            for (int i=0;i<2;i++) {
                Console.WriteLine("enter _id ,_to, _from, _subject, _content, _receivedData, _size");
                string input=Console.ReadLine();
                string[] arrinput = input.Split(',');
                long id = long.Parse(arrinput[0]);
                string to = arrinput[1];
                string from = arrinput[2];
                string subject = arrinput[3];
                string content = arrinput[4];
                //DateTime receivedDate=DateTime.Parse(arrinput[5]);
                           Convert.ToDouble(mail1[6]));
                           
                double size= long.Parse(arrinput[5]);*/

    }
         }


    

