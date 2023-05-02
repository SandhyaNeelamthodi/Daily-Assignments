using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mailreq2
{
    public class Program
    {
        static void Main(string[] args)
        {
            
                List<Mail> ls = new List<Mail>();
                Console.WriteLine("enter the name of mail");
                string Name = Console.ReadLine();
                Mail m = new Mail();
                Mailfolder mf = new Mailfolder(Name, ls);
                while (true)
                {
                    Console.WriteLine("enter a choice\n 1-Addmail\n2-Remove mail\n3-Display mail\n 4-exit");
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            Console.WriteLine("enter the details");
                            string details = Console.ReadLine();
                            m = Mail.CreateMail(details);
                            mf.AddMailToFolder(m);
                            Console.WriteLine("mail added successfully");
                            break;
                        case 2:
                            Console.WriteLine("enter the id to be deleted");
                            int id = int.Parse(Console.ReadLine());
                            mf.RemoveMailFromFolder(id);
                            break;
                        case 3:
                            mf.DisplayMails();
                            break;
                    case 4:

                        break;

                    default:

                        Console.WriteLine("Invalid choice");

                        break;

                }
            }
                }



            
        
    }
}

