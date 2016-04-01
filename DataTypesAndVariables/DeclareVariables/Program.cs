using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteVar = 97;
            sbyte sbyteVar = -115;
            ushort ushortVar = 52130;
            int intVar = -10000;
            uint uintVar = 4825932;

            Console.WriteLine("Byte 97 -> {0}", byteVar);
            Console.WriteLine("Sbyte -115 -> {0}", sbyteVar);
            Console.WriteLine("Ushort 52130 -> {0}", ushortVar);
            Console.WriteLine("Int -10000 -> {0}", intVar);
            Console.WriteLine("Uint 4825932 -> {0}", uintVar);
        }
    }
}
