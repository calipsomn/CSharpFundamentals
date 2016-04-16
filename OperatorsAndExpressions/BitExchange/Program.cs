using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            char[] bits = new char[33];
            string binary = Convert.ToString(n, 2);
            for (int bitInd = 0, numberInd =binary.Length - 1 ; bitInd <33; bitInd++, numberInd--)
            {
                if (numberInd >= 0)
                    bits[bitInd] = binary[numberInd];
                else
                    bits[bitInd] = '0';
            }
            char thirdBit = bits[3];
            bits[3] = bits[24];
            bits[24] = thirdBit;
            char fourthBit = bits[4];
            bits[4] = bits[25];
            bits[25] = fourthBit;
            char fifthBit = bits[5];
            bits[5] = bits[26];
            bits[26] = fifthBit;
            var exchanged = new string(new string(bits).Reverse<char>().ToArray());
            Console.WriteLine(Convert.ToUInt64(exchanged, 2));
        }
    }
}
