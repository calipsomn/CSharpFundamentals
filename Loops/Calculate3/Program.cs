using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int bigger = 1;
            int smaller = 1;
            if (k > n - k)
            {
                bigger = k;
                smaller = n - k;
            }
            else
            {
                smaller = k;
                bigger = n - k;
            }

            BigInteger numerator = 1;
            BigInteger denominator = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i <= smaller)
                {
                    denominator = denominator * i;
                    continue;
                }
                if (i > bigger)
                {
                    numerator = numerator * i;
                    continue;
                }
            }
            Console.WriteLine( numerator / denominator);
        }
    }
}
