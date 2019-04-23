using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class DynamicDemo
    {
        static void Main(string[] args)
        {
            dynamic r;

            r = "Abc";
            Console.WriteLine(r.Length);
            
            r = DateTime.Now;
            Console.WriteLine(r.year); // Throws exception as year is not in DateTime

        }
    }
}
