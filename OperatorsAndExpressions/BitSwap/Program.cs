using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            char[] bits = new char[33];
            string binary = Convert.ToString(n, 2);
            for (int bitInd = 0, numberInd = binary.Length - 1; bitInd < 33; bitInd++, numberInd--)
            {
                if (numberInd >= 0)
                    bits[bitInd] = binary[numberInd];
                else
                    bits[bitInd] = '0';
            }
            for (int firstInd = p, secondInd = q; firstInd <= p + k - 1 && secondInd <= q + k - 1; 
                firstInd++, secondInd++)
            {
                char firstNumber = bits[firstInd];
                bits[firstInd] = bits[secondInd];
                bits[secondInd] = firstNumber;
            }
            var exchanged = new string(new string(bits).Reverse<char>().ToArray());
            Console.WriteLine(Convert.ToUInt64(exchanged, 2));
        }
    }
}
