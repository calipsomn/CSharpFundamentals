using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersFromOneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 1; number <= n; number++)
            {
                Console.WriteLine(number);
            }
        }
    }
}
