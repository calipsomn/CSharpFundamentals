using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if(double.Equals(a,0.0)||double.Equals(b,0.0)||double.Equals(c,0.0))
            {
                Console.WriteLine("0");
                return;
            }
            bool negative = false;
            if (a < 0) 
                negative = !negative;
            if (b < 0)
                negative = !negative;
            if (c < 0)
                negative = !negative;
            Console.WriteLine(negative ? "-" : "+");
        }
    }
}
