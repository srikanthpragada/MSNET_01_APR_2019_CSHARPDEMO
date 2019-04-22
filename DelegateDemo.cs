using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class DelegateDemo
    {
        delegate void PrintDelegate(string message); // 1
        delegate int MathOp(int n1, int n2);

        static void Main(string[] args)
        {
            PrintDelegate d = Print;  // Method Group Conversion
            d.Invoke("Hello!");
            //Lambda Expression
            MathOp op = (a, b) => a * b;
            Console.WriteLine(op(10, 20));


        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
    }
}
