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
            Console.WriteLine("_id ,_to, _from, _subject, _content, _receivedData, _size");
            string input=Console.ReadLine();
            string[] arrinput=input.Split(',');
            
            Mail e1 = new Mail();
            Console.WriteLine(e1.ToString());
            Mail e2 = new Mail();
            Console.WriteLine(e2.ToString());
            
        }
        
            
                
              
            
        
    }
}
