using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            for(int number = n + 1; number < m; number++)
            {
                if (number % 5 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}
