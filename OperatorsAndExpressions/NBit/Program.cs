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
            ulong unsignedLong = ulong.Parse(Console.ReadLine());
            int ind = int.Parse(Console.ReadLine());

            string binary = Convert.ToString((long)unsignedLong, 2);
            int binaryLength = binary.Length;
            if (ind > binaryLength)
            {
                for (int i = 0; i < ind - binaryLength; i++)
                {
                    binary = binary.Insert(0, "0");
                }
            }
            Console.WriteLine(new string(binary.Reverse<char>().ToArray<char>())[ind - 1]);
        }
    }
}
