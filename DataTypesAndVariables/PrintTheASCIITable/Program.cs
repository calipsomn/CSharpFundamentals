using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 128; i++)
            {
                char ch = (char)i;
                if (char.IsControl(ch))
                    continue;

                Console.Write(ch + " ");
            }
        }
    }
}
