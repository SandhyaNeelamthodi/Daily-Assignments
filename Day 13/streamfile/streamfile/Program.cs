using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamfile
{
    internal class Program
    {
        static string file = @"D:\dotnet training\Day 13\egfolder";
        static void Main(string[] args)
        {
            Write();
            Read();

        }
         static void Write() 
        { 
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("India is Great");
            fileStream.WriteLine("India is beautiful");
            fileStream.Close();
        }
        static void Read()
        {
            StreamWriter fileStream = new StreamWriter(file);
            string s = null;
            while((s=fileStream.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            fileStream.Close();
        }

    }
}
