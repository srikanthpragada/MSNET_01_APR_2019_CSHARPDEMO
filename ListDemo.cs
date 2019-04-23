using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            //var names = new List<string>();
            //names.Add("Anders");
            //names.Add("Bill");
            //names.Insert(0, "James");
            //names.Add("Anders");

            //Console.WriteLine(names.Contains("Bill"));

            //foreach(string n in names)
            //    Console.WriteLine(n);

            StreamReader sr = new StreamReader(@"e:\classroom\msnet\apr1\names.txt");
            var names = new List<string>();

            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                    break;
                names.Add(line);
            }

            sr.Close();

            names.Sort(); 
            foreach(string n in names)
                Console.WriteLine(n);

            names.Sort( (s1,s2) => s1.Length - s2.Length); // Sort by length
            foreach (string n in names)
                Console.WriteLine(n);

            

        }
    }
}
