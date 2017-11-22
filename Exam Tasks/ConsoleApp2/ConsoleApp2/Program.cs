using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            long brickOne = long.Parse(Console.ReadLine());
            long brickTwo = long.Parse(Console.ReadLine());
            long brickThree = long.Parse(Console.ReadLine());
            long L = long.Parse(Console.ReadLine());
            List<long> number = new List<long>();
            number.Add(brickOne);
            number.Add(brickTwo);
            number.Add(brickThree);
            int index = 3;
            if (L > 20) L = 20;

            Console.WriteLine("{0}\n{1} {2}", brickOne, brickTwo, brickThree);
            for (int line = 3; line < L + 1; line++)
            {
                for (int i = 0; i < line; i++)
                {
                    long brick = number[index - 1] + number[index - 2] + number[index - 3];
                    if (i != 0) Console.Write(" ");
                    Console.Write("{0}", brick);
                    index++;
                    number.Add(brick);
                }
                Console.WriteLine();
            }
        }
    }
}
