using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05_Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRegex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            //Has either whitespace before it or the end of the string (match either $ or what’s called a positive lookahead). 
            //The syntax for the end of the RegEx might look something like “($|(?=\s))”. <= for forward, = for back.

            string numbers = Console.ReadLine();

            MatchCollection solution = Regex.Matches(numbers, toRegex);

            foreach (Match num in solution)
            {
                Console.Write(num.Value + " ");
            }

            Console.WriteLine();
        }
    }
}