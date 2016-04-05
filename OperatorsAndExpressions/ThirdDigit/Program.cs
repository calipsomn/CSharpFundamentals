using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var thirdDigit = n.ToString("D3").Reverse<char>().ToArray()[2];
            Console.WriteLine(thirdDigit == '7' ? "true" : "false " + thirdDigit);
        }
    }
}
