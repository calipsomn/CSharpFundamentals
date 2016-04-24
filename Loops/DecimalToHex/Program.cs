using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            List<char> hexNumber = new List<char>();
            do
            {
                ulong reminder = number % 16;
                number /= 16;
                char hexSymbol;
                switch (reminder)
                {
                    case 10: hexSymbol = 'A'; break;
                    case 11: hexSymbol = 'B'; break;
                    case 12: hexSymbol = 'C'; break;
                    case 13: hexSymbol = 'D'; break;
                    case 14: hexSymbol = 'E'; break;
                    case 15: hexSymbol = 'F'; break;
                    default: hexSymbol = reminder.ToString()[0]; break;
                }
                hexNumber.Insert(0, hexSymbol);
            }
            while (number > 0);
            Console.WriteLine(new string(hexNumber.ToArray()));
        }
    }
}
