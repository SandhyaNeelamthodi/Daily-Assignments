using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Duplicatewords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of sentences");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sentences");
            string[] sentences= new string[n];
            for(int i= 0; i < n; i++)
            {
                sentences[i] = Console.ReadLine();
            }
            string[] result = RemoveDuplicates(sentences, n);
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
        public static string[] RemoveDuplicates(string[] sentences,int n)
        {
            for(int i= 0;i < n;i++) 
            {
                string sentence= sentences[i];
                string result = Regex.Replace(sentence, @"\b(\w+)(\s+\1)+\b", "$1", RegexOptions.IgnoreCase);
                sentences[i] = result;
            }
            return sentences;

        }
    }
}
