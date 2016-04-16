using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            var specifier = "0.00";
            double desc = b * b - 4 * a * c;
            if(desc<0)
            {
                Console.WriteLine("no real roots");
                return;
            }
            if (desc == 0.0)
            {
                Console.WriteLine((-b / (2 * a)).ToString(specifier));
                return;
            }
            double x1 = (-b - Math.Sqrt(desc)) / (2 * a);
            double x2 = (-b + Math.Sqrt(desc)) / (2 * a);
            Console.WriteLine(x1.ToString(specifier));
            Console.WriteLine(x2.ToString(specifier));
        }
    }
}
