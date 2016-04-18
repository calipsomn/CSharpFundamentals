using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double biggest = a > b ? a : b;
            biggest = c > biggest ? c : biggest;
            biggest = d > biggest ? d : biggest;
            biggest = e > biggest ? e : biggest;
            Console.WriteLine(biggest);
        }
    }
}
