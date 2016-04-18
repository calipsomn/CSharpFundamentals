using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            switch (str.Trim().ToLower())
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "j":
                case "q":
                case "k":
                case "a": Console.WriteLine("yes {0}", str); break;
                default: Console.WriteLine("no {0}", str); break;
            }
        }
    }
}
