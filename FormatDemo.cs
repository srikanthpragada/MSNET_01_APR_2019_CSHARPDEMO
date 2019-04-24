using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class FormatDemo
    {
        static void Main(string[] args)
        {
            double d = 393939393.2213;

            CultureInfo c = new CultureInfo("en-US");
            // Thread.CurrentThread.CurrentCulture = c; 
            Console.WriteLine("{0:c}",d);
            Console.WriteLine(d.ToString("c",c.NumberFormat));

            Console.WriteLine(DateTime.Now.ToString("d",c));

            Console.WriteLine(string.Format("{0:f}",DateTime.Now));

            Console.WriteLine("{0:dd-MM-yyyy HH:mm:ss}", DateTime.Now);


        }
    }
}
