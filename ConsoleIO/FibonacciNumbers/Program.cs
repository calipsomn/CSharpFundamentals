using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 0;
            long b = 1;
            int n = int.Parse(Console.ReadLine());
            List<long> fibonacci = new List<long>();
            fibonacci.Add(a); fibonacci.Add(b);
            while (fibonacci.Count < n)
            {
                long temp = b;
                b = b + a;
                a = temp;
                fibonacci.Add(b);
            }
            Console.Write(fibonacci[0]);
            for (int ind = 1; ind < n; ind++)
            {
                Console.Write(", {0}", fibonacci[ind]);
            }
        }
    }
}
