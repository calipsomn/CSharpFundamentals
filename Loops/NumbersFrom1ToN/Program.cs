using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for (uint number = 1; number <= n; number++)
            {
                Console.Write(number);
                if (number < n)
                    Console.Write(" ");
            }
        }
    }
}
