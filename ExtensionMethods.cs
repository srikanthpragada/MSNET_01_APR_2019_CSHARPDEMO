using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    static class ExMethods
    {
        static public void Print(this MyTime time)
        {
           Console.WriteLine($"{time.Hours}:{time.Mins}:{time.Secs}");
        }
    }
    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            MyTime t = new MyTime { Hours = 10, Mins = 10, Secs = 10 };
            // ExMethods.Print(t);
            t.Print(); 

        }
    }
}
