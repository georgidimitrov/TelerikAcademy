using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            if (input.Length == 20) Console.WriteLine(input);
            else
            {
                for (int i = 0; i < 20 - length; i++)
                {
                    input += "*";
                }
                Console.WriteLine(input);
            }
        }
    }
}
