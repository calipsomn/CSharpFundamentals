using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double double1 = double.Parse(Console.ReadLine());
            double double2 = double.Parse(Console.ReadLine());
            double difference = Math.Abs(double1 - double2);
            Console.WriteLine(difference < 0.000001 ? "true" : "false");
        }
    }
}
