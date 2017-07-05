using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05_Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Regex toRegex = new Regex(@"(\d+)([A-Za-z])");

            MatchCollection replacer = toRegex.Matches(inputLine);

            foreach (Match find in replacer)
            {
                inputLine = Regex.Replace(inputLine, find.Groups[1].Value.ToString(), find.Groups[2].Value.ToString());
            }
            Console.WriteLine(inputLine);
        }
    }
}