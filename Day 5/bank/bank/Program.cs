using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            Account a = null;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.create account");
                Console.WriteLine("2.displayinfo");
                Console.WriteLine("3.deposit amount");
                Console.WriteLine("4.withdraw");
                Console.WriteLine("5.Current balance");
                Console.WriteLine("0.Quit");
                Console.WriteLine("enter the choice");

                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {

                    case 1:
                        Console.WriteLine("enter the account id");
                        int Id= int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name");
                        string Name=Console.ReadLine();
                        Console.WriteLine("enter opening balance:");
                        double Balance=double.Parse(Console.ReadLine());
                        a = new Account();
                        a.createaccount(Id,Name, Balance);

                        break;
                    case 2:
                        if (a != null)
                        {
                            a.displayinfo();
                        }
                        else
                            Console.WriteLine("open an account");
                        break;
                    case 3:
                        if (a != null)
                        {
                            Console.WriteLine("Enter the amount");
                            double dep= double.Parse(Console.ReadLine());
                            a.deposit(dep);
                        }
                        else
                            Console.WriteLine("open an account");
                        break;
                   case 4:
                        if (a != null)
                        {
                            Console.WriteLine("enter the amount");
                            double amount=double.Parse(Console.ReadLine());
                            a.withdraw(amount);
                        }
                        break;
                   case 5:
                        if(a != null)
                        { 
                            
                        a.Currentbalance();
                        }
                        break;
                   case 0:
                        break;
                   
                   default:
                        {
                            Console.WriteLine("wrong choice");

                        }
                        break;





                }
            }
            while (ch != 0);
            {
                Console.WriteLine("thank you");
            }








        }
            
            
            
                
            
            

        
    }
}
