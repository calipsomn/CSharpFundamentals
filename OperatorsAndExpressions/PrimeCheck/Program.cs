using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var prime = true;
            if (number <= 1)
            {
                Console.WriteLine("false");
                return;
            }

            for (int divider = 2; divider < number / 2 + 1; divider ++)
            {
                if (number % divider == 0)
                {
                    prime = false;
                    break;
                }
            }

            Console.WriteLine(prime.ToString().ToLower());
        }
    }
}
