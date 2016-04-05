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
            Console.WriteLine(binary.Reverse<char>().ElementAt(ind ));
        }
    }
}
