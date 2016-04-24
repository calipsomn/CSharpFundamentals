using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger numerator = 1;
            BigInteger denominator = 1;
            if (n == 0)
            {
                Console.WriteLine(1);
                return;
            }
            
            for (int number = 1; number <= 2 * n; number++)
            {
                if (number <= n)
                    denominator *= number;
                if (number > n + 1)
                    numerator *= number;
            }
            Console.WriteLine(numerator / denominator);
        }
    }
}
