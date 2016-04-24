using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            List<char> binary = new List<char>();
            do
            {
                if (number % 2 == 0)
                    binary.Insert(0, '0');
                else
                    binary.Insert(0, '1');
                number /= 2;
            }
            while (number > 0);
            Console.WriteLine(new string(binary.ToArray()));
        }
    }
}
