using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':').ToArray();

            input[1] = input[1].TrimStart('/');
            string[] serverAndResource = input[1].Split(new char[] { '/' }, 2);

            Console.WriteLine("[protocol] = " + input[0]);
            Console.WriteLine("[server] = " + serverAndResource[0]);
            Console.WriteLine("[resource] = /" + serverAndResource[1]);
        }
    }
}
