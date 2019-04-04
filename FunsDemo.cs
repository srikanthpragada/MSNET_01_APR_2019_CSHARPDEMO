using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class FunsDemo
    {
        static int Add(int n1 = 10, int n2 = 0)
        {
            return n1 + n2;
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Zero(out int a, out int b)
        {
           a = b = 0; 
        }

        static void Main(string[] args)
        {
            int x, y;

            Zero(out x, out y);
            Console.WriteLine($"{x} {y}");

            //Swap(x, y);
            //Console.WriteLine($"{x},{y}");

            //Console.WriteLine(Add(10, 20));
            //Console.WriteLine(Add(100));
            //Console.WriteLine(Add());
            //Console.WriteLine(Add(n2: 200, n1: 100));
        }
    }
}
