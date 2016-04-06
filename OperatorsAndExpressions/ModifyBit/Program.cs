using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            int binaryLength = binary.Length;
            if (p > binaryLength)
            {
                for (int i = 0; i <= p - binaryLength; i++)
                {
                    binary = binary.Insert(0, "0");
                }
            }
            binary = binary.Remove(binary.Length - p - 1, 1);
            binary = binary.Insert(binary.Length - p, v.ToString());
            Console.WriteLine(Convert.ToUInt64(binary, 2));
        }
    }
}
