using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class DisplaySourceCode
    {
        static void Main(string[] args)
        {
            var dirname = @"e:\classroom\msnet\apr1\csharpdemo";
            DirectoryInfo dinfo = new DirectoryInfo(dirname);
        
            foreach(FileInfo finfo in dinfo.GetFiles())
            {
                if (finfo.Extension == ".cs")
                    PrintSourceCode(finfo);
            }
        }

        static void PrintSourceCode(FileInfo finfo)
        {
            StreamReader sr = new StreamReader(finfo.FullName);
            int lineno = 1;
            Console.WriteLine("\n==================================");
            Console.WriteLine($"Filename : {finfo.Name}");
            Console.WriteLine("==================================\n");
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break; 
                Console.WriteLine($"{lineno.ToString("0000")} : {line}");
                lineno++;
            }

            sr.Close(); 
        }
    }
}
