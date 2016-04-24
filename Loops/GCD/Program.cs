using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');
            ulong a = ulong.Parse(numbers[0]);
            ulong b = ulong.Parse(numbers[1]);
            ulong firstNumber = a > b ? a : b;
            ulong secondNumber = a > b ? b : a;
            ulong reminder = secondNumber;
            do
            {
                reminder = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = reminder;
            }
            while (reminder > 0);
            Console.WriteLine(firstNumber);
        }
    }
}
