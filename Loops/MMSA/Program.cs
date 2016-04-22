using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSA
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = long.Parse(Console.ReadLine());
            double sum = 0.00;
            double min = long.MaxValue;
            double max = long.MinValue;
            for (long i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", sum /n);
        }
    }
}
