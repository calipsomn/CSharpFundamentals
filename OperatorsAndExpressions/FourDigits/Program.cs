using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int a = int.Parse(input[0].ToString());
            int b = int.Parse(input[1].ToString());
            int c = int.Parse(input[2].ToString());
            int d = int.Parse(input[3].ToString());
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", input[3], input[2], input[1], input[0]);
            Console.WriteLine("{0}{1}{2}{3}", input[3], input[0], input[1], input[2]);
            Console.WriteLine("{0}{1}{2}{3}", input[0], input[2], input[1], input[3]);
        }
    }
}
