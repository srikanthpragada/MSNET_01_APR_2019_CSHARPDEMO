using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class UniqueChars
    {
        static void Main(string[] args)
        {
            string st = "How are you. How do you do?";
            var chars = new HashSet<char>();

            for (int i = 0; i < st.Length; i++)
                chars.Add(st[i]);

            foreach(char c in chars)
                Console.WriteLine(c);

        }
    }
}
