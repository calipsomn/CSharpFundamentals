using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisibleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("1");
            for (ulong i = 2; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(" {0}", i);
                    continue;
                }
            }
        }
    }
}
