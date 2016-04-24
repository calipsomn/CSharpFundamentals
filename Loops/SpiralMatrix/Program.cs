using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            var matrix = new int[number, number];
            int firstRow = 0;
            int firstColumn = 0;
            int lastRow = number - 1;
            int lastColumn = number - 1;
            int currentRow = 0;
            int currentColumn = 0;
            while (currentNumber <= number * number)
            {
                for (currentColumn = firstColumn; currentColumn <= lastColumn; currentColumn++)
                {
                    matrix[currentRow, currentColumn] = currentNumber;
                    currentNumber++;
                }
                if (currentNumber > number * number)
                    break;
                firstRow++;
                currentColumn--;
                for (currentRow = firstRow; currentRow <= lastRow; currentRow++)
                {
                    matrix[currentRow, currentColumn] = currentNumber;
                    currentNumber++;
                }
                if (currentNumber > number * number)
                    break;
                lastColumn--;
                currentRow--;
                for (currentColumn = lastColumn; currentColumn >= firstColumn; currentColumn--)
                {
                    matrix[currentRow, currentColumn] = currentNumber;
                    currentNumber++;
                }
                if (currentNumber > number * number)
                    break;
                lastRow--;
                currentColumn++;
                for (currentRow = lastRow; currentRow >= firstRow; currentRow--)
                {
                    matrix[currentRow, currentColumn] = currentNumber;
                    currentNumber++;
                }
                if (currentNumber > number * number)
                    break;
                currentRow++;
                firstColumn++;
            }
            for (int row = 0; row < number; row++)
            {
                for (int column = 0; column < number; column++)
                {
                    Console.Write("{0} ", matrix[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
