using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class Program
    {
        static void Main(string[] args)
        {
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine((w * 17.00 / 100.00).ToString("0.000"));
        }
    }
}
