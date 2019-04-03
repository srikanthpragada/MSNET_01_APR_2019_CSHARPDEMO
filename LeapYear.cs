using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Enter year : ");
            year = Int32.Parse(Console.ReadLine());

            if (year % 4 == 0)
                // String interpolation 
                Console.WriteLine($"{year} is Leap Year"); 
            else
                Console.WriteLine($"{year} is Not a Leap Year");

        }
    }
}
