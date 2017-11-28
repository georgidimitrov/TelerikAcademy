using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rowMax = Convert.ToInt32(input[0]);
            int columnMax = Convert.ToInt32(input[1]);
            int[,] matrix = new int[rowMax, columnMax];
            bool[] switches = new bool[4];
            List<int> maximums = new List<int>(new int[] { 1, 1, 1, 1});

            for (int row = 0; row < rowMax; row++)
            {
                string[] buffer = Console.ReadLine().Split();
                for (int column = 0; column < columnMax; column++)
                {
                    matrix[row, column] = Convert.ToInt32(buffer[column]);
                }
            }

            
            for (int row = 0; row < rowMax; row++)
            {
                for (int column = 0; column < columnMax; column++)
                {
                    //0 - column; 1 - row; 2 - up; 3 - down
                    switches = new bool[4];
                    int tempColCounter = 1;
                    int tempRowCounter = 1;
                    int tempUpCounter = 1;
                    int tempDownCounter = 1;
                    //cell logistics
                    for (int counter = 1; counter < Math.Max(rowMax, columnMax); counter++)
                    {
                        if (column + counter < columnMax && !switches[0] && matrix[row, column] == matrix[row, column + counter])
                        {
                            tempColCounter++;
                        }
                        else switches[0] = true;
                        
                        if (row + counter < rowMax && !switches[1] && matrix[row, column] == matrix[row + counter, column])
                        {
                            tempRowCounter++;
                        }
                        else switches[1] = true;

                        if (row - counter > -1 && column + counter < columnMax && !switches[2] && matrix[row, column] == matrix[row - counter, column + counter])
                        {
                            tempUpCounter++;
                        }
                        else switches[2] = true;

                        if (row + counter < rowMax && column + counter < columnMax && !switches[3] && matrix[row, column] == matrix[row + counter, column + counter])
                        {
                            tempDownCounter++;
                        }
                        else switches[3] = true;
                    }

                    maximums[0] = Math.Max(tempColCounter, maximums[0]);
                    maximums[1] = Math.Max(tempRowCounter, maximums[1]);
                    maximums[2] = Math.Max(tempUpCounter, maximums[2]);
                    maximums[3] = Math.Max(tempDownCounter, maximums[3]);
                    
                }

            }
            Console.WriteLine(maximums.Max());
        }
    }
}
