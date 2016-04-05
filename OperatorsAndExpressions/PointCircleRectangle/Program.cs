using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Sqrt((x - 1.0) * (x - 1) + (y - 1) * (y - 1));
            var insideCircle = distance <= 1.5;
            var insideRectangle = x <= 5.0 && x >= -1.0 && y <= 1.0 && y >= -1;
            Console.WriteLine("{0} circle {1} rectangle", insideCircle ? "inside" : "outside", insideRectangle ? "inside" : "outside");
        }
    }
}
