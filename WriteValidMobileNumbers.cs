using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class WriteValidMobileNumbers
    {
        static bool IsValidMobile(string mobile)
        {
            if (mobile.Length != 10)
                return false;

            // Check whether string has only digits 
            for (int i = 0; i < mobile.Length; i++)
                if (!Char.IsDigit(mobile[i]))
                    return false;

            return true; 
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"e:\classroom\msnet\apr1\mobile.txt");
            StreamWriter sw = new StreamWriter(@"e:\classroom\msnet\apr1\valid_mobile.txt");

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null) // EOF
                    break;

                string [] mobiles = line.Split(',',':',';',' ');

                foreach (var s in mobiles)
                {
                    if (IsValidMobile(s))
                    {
                        Console.WriteLine(s);
                        sw.WriteLine(s);
                    }
                } // foreach
            }

            sr.Close();
            sw.Close(); 
        }
    }
}
