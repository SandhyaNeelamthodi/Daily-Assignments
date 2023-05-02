using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Carpooling_req1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Member> list = new List<Member>();
            for (int i = 0; i < 2; i++)
            {


                Console.WriteLine("enter the details");
                long _id = int.Parse(Console.ReadLine());
                string _firstname = Console.ReadLine();
                string _lastname = Console.ReadLine();
                string _email = Console.ReadLine();
                string _contactNumber = Console.ReadLine();
                string _licensenumber = Console.ReadLine();
                DateTime _startDate = DateTime.Parse(Console.ReadLine());
                DateTime _expiryDate = DateTime.Parse(Console.ReadLine());
                Member m = new Member(_id,_firstname,_lastname,_email,_contactNumber,_licensenumber,_startDate,_expiryDate);
                list.Add(m);    
                  
            }
            if (list[0].Equals(list[1]))
            {
                Console.WriteLine("Member1 same as Member2");
            }
            else
            {
                Console.WriteLine("Member1 and Member2 are different");
            }

            

        }
    }
}
