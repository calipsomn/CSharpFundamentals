using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong k = ulong.Parse(Console.ReadLine());
            BigInteger result = 1;
            ulong border = 100 > n ? n : 99;
            for (ulong number = k + 1; number <= n; number++)
            {
                result *= number;
            }
            Console.WriteLine(result);
        }
    }
}
