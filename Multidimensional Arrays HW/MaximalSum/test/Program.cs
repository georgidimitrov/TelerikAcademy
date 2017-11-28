using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string []input = Console.ReadLine().Split();
            int rowMax = Convert.ToInt32(input[0]);
            int columnMax = Convert.ToInt32(input[1]);
            int maximum = int.MinValue;
            int [,]matrix = new int[rowMax, columnMax];

            for (int row = 0; row < rowMax; row++)
            {
                string[] buffer = Console.ReadLine().Split();
                for (int column = 0; column < columnMax; column++)
                {
                    matrix[row, column] = Convert.ToInt32(buffer[column]);
                }    
            }

            for (int rowPosition = 0; rowPosition < rowMax; rowPosition++)
            {
                for (int columnPosition = 0; columnPosition < columnMax; columnPosition++)
                {
                    if (!OutOfBoundsCheck(rowMax, columnMax, rowPosition, columnPosition)) break;
                    int max = matrix[rowPosition, columnPosition] + matrix[rowPosition, columnPosition + 1] + matrix[rowPosition, columnPosition + 2]
                       + matrix[rowPosition + 1, columnPosition] + matrix[rowPosition + 1, columnPosition + 1] + matrix[rowPosition + 1, columnPosition + 2]
                       + matrix[rowPosition + 2, columnPosition] + matrix[rowPosition + 2, columnPosition + 1] + matrix[rowPosition + 2, columnPosition + 2];
                    maximum = Math.Max(max, maximum);
                }
            }
            Console.WriteLine(maximum);

        }
        static bool OutOfBoundsCheck(int rowMax, int columnMax, int rowPosition,int columnPosition)
        {
            int checks = 0;
            if (columnPosition + 2 < columnMax) checks++;
            if (rowPosition + 2 < rowMax) checks++;
            if (checks == 2) checks++;

            if (checks == 3) return true;
            else return false;
        }

    }
     
}
