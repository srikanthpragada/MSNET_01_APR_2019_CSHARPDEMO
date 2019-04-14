using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class TestDateTime
    {
        static void Main(string[] args)
        {
            var ct = DateTime.Now;
            Console.WriteLine(ct.ToString());
            Console.WriteLine(ct.ToLongDateString());

            var sd = new DateTime(2019, 1, 1);
            var ts = ct.Subtract(sd);
            Console.WriteLine($"No. of days : {ts.Days}");
        }
    }
}
