using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _23SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string output = Regex.Replace(input, @"(\w)\1+", match => match.Groups[1].ToString());
            Console.WriteLine(output);
        }
    }
}
