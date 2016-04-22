using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double result = 1.0;
            ulong numerator = 1;
            double denominator = 1.0;
            for (int pow = 1; pow <= n; pow++)
            {
                numerator *= (ulong)pow;
                denominator *= x;
                result += ((double)numerator / denominator);
            }
            Console.WriteLine(result.ToString("0.00000"));
        }
    }
}
