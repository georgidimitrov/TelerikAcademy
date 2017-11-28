using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToUpper();
            string input = Console.ReadLine().ToUpper();
            Regex reg = new Regex(Regex.Escape(pattern));
            
            int count = reg.Matches(input).Count;

            Console.WriteLine(count);
        }
    }
}
