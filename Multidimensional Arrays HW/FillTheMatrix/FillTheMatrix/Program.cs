using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string typeOfMatrix = Console.ReadLine();
            int[,] matrix = new int[N, N];
            int Number = 1;

            if (typeOfMatrix == "a")
            {
                for (int column = 0; column < N; column++)
                {
                    for (int row = 0; row < N; row++)
                    {
                        matrix[row, column] = N * column + row + 1;
                    }
                }
            }
            else if (typeOfMatrix == "b")
            {
                for (int column = 0; column < N; column += 2)
                {
                    for (int row = 0; row < N; row++)
                    {
                        matrix[row, column] = Number;
                        Number++;
                    }
                    for (int rowUp = N - 1; rowUp >= 0; rowUp--)
                    {
                        if (column + 1 >= N) break;
                        matrix[rowUp, column + 1] = Number;
                        Number++;
                    }
                }
            }
            else if (typeOfMatrix == "c")
            {
                for (int matrixChanges = 0; matrixChanges < N + 2; matrixChanges++)
                {
                    int column = 0;
                    int row = N - matrixChanges + 1;
                    for (int mainCycle = matrixChanges - 1; mainCycle > 0; mainCycle--)
                    {
                        matrix[row, column] = Number++;
                        row++;
                        column++;
                    }
                }
                for (int matrixChanges = N - 1; matrixChanges > 0; matrixChanges--)
                {
                    int row = 0;
                    int column = N - matrixChanges;
                    for (int mainCycle = matrixChanges; mainCycle > 0; mainCycle--)
                    {
                        matrix[row, column] = Number++;
                        row++;
                        column++;
                    }
                }
            }
            /*else if (typeOfMatrix == "d")
            {
                int helper = 0;
                int right = 0;
                int left = ;
                int top = ;
                int bot = ;
                for (int arrows = 0; arrows < N*2 - 1; arrows++)
                {
                    if (helper == 0)
                    {
                        for (int i = 0; i < ; i++)
                        {
                            matrix[ ]
                        }
                    }
                }
            }*/




            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    Console.Write("{0} ", matrix[row,column]);
                }
                Console.WriteLine();
            }
        }


    }
}
