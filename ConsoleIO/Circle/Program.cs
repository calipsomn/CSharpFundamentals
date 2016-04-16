using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            var specifier="0.00";
            Console.WriteLine("{0} {1}", (2.0 * Math.PI * r).ToString(specifier), (Math.PI * r * r).ToString(specifier));
        }
    }
}
