using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            BigInteger power = 1;
            BigInteger result = 0;
            foreach (char hexSymbol in input.ToUpper().Reverse<char>())
            {
                int number;
                switch (hexSymbol)
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: number = int.Parse(hexSymbol.ToString()); break;
                }
                result += (number * power);
                power *= 16;
            }
            Console.WriteLine(result);
        }
    }
}
