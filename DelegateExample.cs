using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class DelegateExample
    {
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 11, 13, 35, 40, 12, 23, 30, 44 };

            var sa = Array.FindAll(a, n => n % 2 != 0);
            foreach(int n in sa)
              Console.WriteLine(n);

        }
    }
}
