using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trailing0InN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int zeroes = 0;
            int number = (n / 5) * 5;
            int power = 5;
            while (power <= n)
            {
                zeroes += (n / power);
                power *= 5;
            }
            Console.WriteLine(zeroes);
        }
    }
}
