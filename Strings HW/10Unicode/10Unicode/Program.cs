using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                Console.Write("\\u" + ((int)c).ToString("X4"));
            }
        }
    }
}
