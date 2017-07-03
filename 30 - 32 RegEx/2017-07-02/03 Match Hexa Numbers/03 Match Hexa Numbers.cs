using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Match_Hexa_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRegex = @"\b(?:0x)?([0-9A-F]+)\b";

            string input = Console.ReadLine();

            string[] solution = Regex.Matches(input, toRegex)
                .Cast<Match>()
                .Select(match => match.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", solution));
        }
    }
}