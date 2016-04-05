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
            Console.WriteLine("{0:F3}", (w * 17.000f / 100.000f));
        }
    }
}
