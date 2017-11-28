using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _15ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Regex.Replace(input, @"<a href=""(.*?)"">(.*?)<\/a>", match => "["+ match.Groups[2].ToString() +"]" + "("+ match.Groups[1].ToString() +")");
            Console.WriteLine(output);
        }
    }
}
