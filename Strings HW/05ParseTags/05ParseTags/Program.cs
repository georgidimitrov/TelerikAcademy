using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output;
            output = Regex.Replace(input, @"<upcase>(.*?)<\/upcase>", word => word.Groups[1].ToString().ToUpper());
            Console.WriteLine(output);
        }
    }
}
