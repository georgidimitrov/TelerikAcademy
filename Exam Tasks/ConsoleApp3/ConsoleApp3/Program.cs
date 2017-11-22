using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split();
            long sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                long difference = Math.Abs(Convert.ToInt64(numbers[i]) - Convert.ToInt64(numbers[i - 1]));
                if ((difference % 2) == 0)
                {
                    sum += difference;
                    ++i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
