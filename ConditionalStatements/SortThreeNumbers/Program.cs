﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (b > c)
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                else
                {
                    if (c < a)
                        Console.WriteLine("{0} {1} {2}", a, c, b);
                    else
                        Console.WriteLine("{0} {1} {2}", c, a, b);
                }
            }
            else
            {
                if (b < c)
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                else
                {
                    if (a > c)
                        Console.WriteLine("{0} {1} {2}", b, a, c);
                    else
                        Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
        }
    }
}
