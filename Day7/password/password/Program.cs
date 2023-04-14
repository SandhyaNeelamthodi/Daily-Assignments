using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username=null;
            string password=null;
            int c = 0;
            do
            {
                Console.WriteLine("enter the username:");
                username = Console.ReadLine();
                Console.WriteLine("enter the password:");
                password= Console.ReadLine();
                if (username != "abcd" || password != "1234")
                    c++;
            }
            
                while ((username != "abcd" || password != "1234") && (c != 5)) ;
            { 
            if (c==5)
                {
                    Console.WriteLine("only 5 attempts can be done. Please wait");
                }
            else
                {
                    Console.WriteLine("Succesfully logged in");
                }
            }

        }
    }
}
