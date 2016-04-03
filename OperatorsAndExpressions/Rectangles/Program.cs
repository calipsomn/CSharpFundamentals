using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine((width * height).ToString("0.00") + " " + (2 * width + 2 * height).ToString("0.00"));
        }
    }
}
