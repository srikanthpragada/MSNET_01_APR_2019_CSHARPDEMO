using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Stack<T> 
    {
        private T[] data = new T[10];
        private int top = 0;

        public void Reset()
        {
            top = 0;
            for (int i = 0; i < data.Length; i++)
                data[i] = default(T); 
        }

        public void Push(T n)
        {
            data[top] = n;
            top++;
        }

        public T Pop()
        {
            top--;
            return data[top];
        }
    }
    class MyStack
    {
        public static void Print<T>(T [] a)
        {
            foreach (T n in a)
                Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            Console.WriteLine(s.Pop());

            var ss = new Stack<string>();
            ss.Push("Abc");
            ss.Push("Xyz");
            Console.WriteLine(ss.Pop());

            string []  names =  { "Abc", "Xzy" };

            Print(names);
          
        }
    }
}
