using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class AnonymousDemo
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now; 

            var v = new { Hours = 10, Mins = 20, now};


        }
    }
}
