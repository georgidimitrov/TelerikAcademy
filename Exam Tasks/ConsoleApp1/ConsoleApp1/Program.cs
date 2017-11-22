using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int sum = 0;

            while(true)
            {
                foreach (var digit in number)
                {
                    if (digit == '.') continue;
                    if (digit == '-') continue;

                    sum += (int)Char.GetNumericValue(digit);
                }
                if (sum <= 9) break;
                number = sum.ToString();
                sum = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
