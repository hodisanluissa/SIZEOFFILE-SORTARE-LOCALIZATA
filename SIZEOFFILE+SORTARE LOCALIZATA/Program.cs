using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SIZEOFFILE_SORTARE_LOCALIZATA
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //string line;

            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\input.txt");
            //string vocale = "aeiouAEIOU";
            //while ((line = file.ReadLine()) != null)

            const string filename = @"../../input.txt";
            FileInfo info = new FileInfo(filename);
            long lenght = info.Length;
            Console.WriteLine($"size file :{lenght}");

            file.Close();
             
        }
    }
}
