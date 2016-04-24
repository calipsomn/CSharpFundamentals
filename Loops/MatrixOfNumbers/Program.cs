using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                int rowNumber = row + 1;
                for (int column = 0; column < n; column++)
                {
                    Console.Write("{0} ", rowNumber);
                    rowNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}
