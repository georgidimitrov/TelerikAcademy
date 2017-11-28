using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string[] input = Console.ReadLine().Split('.').ToArray();
            StringBuilder result = new StringBuilder();

            pattern = @"(^|\W|[0-9_])" + Regex.Escape(pattern) + @"($|\W|[0-9_])";

            for (int i = 0; i < input.Length; i++)
            {
                if (Regex.Match(input[i], pattern).Success)
                    {
                        result.Append(input[i].Trim() + ". ");
                }
            }
            result.Length--;
            Console.WriteLine(result);
        }   
    }
}
