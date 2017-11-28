using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();
            bool check = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    for (int j = i + 1; j < input.Length; j++)
                    {
                        if (input[j] == ')')
                        {
                            input[j] = '0';
                            input[i] = '0';
                            break;
                        }
                    }
                }
            }

            foreach (char i in input)
            {
                if (i == ')')
                {
                    check = false;
                }
                else if (i == '(')
                {
                    check = false;
                }
            }

            if (check) Console.WriteLine("Correct");
            else Console.WriteLine("Incorrect");
        }
    }
}
