﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 1; i <= 5; )
            {
                Console.Write("Enter a number :");
                try
                {
                    int num = Int32.Parse(Console.ReadLine());
                    sum += num;
                    i++;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Sorry! Invalid Number!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry! An error!");
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
