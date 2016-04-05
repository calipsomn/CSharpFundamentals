using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint unsignedInt = uint.Parse(Console.ReadLine());
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((unsignedInt & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            var bitNumber = new string(b);
            Console.WriteLine(new string(b).Reverse<char>().ElementAt(3));
        }
    }
}
