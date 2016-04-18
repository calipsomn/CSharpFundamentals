using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type.ToLower().Trim()) 
            {
                case "integer": Console.WriteLine(long.Parse(Console.ReadLine()) + 1); break;
                case "real": Console.WriteLine((double.Parse(Console.ReadLine()) + 1).ToString("0.00")); break;
                default: Console.WriteLine("{0}*", Console.ReadLine()); break;
            }
        }
    }
}
