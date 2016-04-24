using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ');
            int current = 1;
            BigInteger evenNumbers = 1;
            BigInteger oddNumbers = 1;
            foreach (var number in numbers)
            {
                int currentNumber = int.Parse(number);
                if (current % 2 == 0)
                    evenNumbers *= currentNumber;
                else
                    oddNumbers *= currentNumber;
                current++;
            }
            if (evenNumbers == oddNumbers)
                Console.WriteLine("yes {0}", evenNumbers);
            else
                Console.WriteLine("no {0} {1}", oddNumbers, evenNumbers);
        }
    }
}
