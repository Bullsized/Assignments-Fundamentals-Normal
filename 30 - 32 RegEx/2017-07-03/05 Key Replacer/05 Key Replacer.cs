using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05_Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex split = new Regex(@"(\w+)([\\\<\|])(\w+)([\|\<\\])(\w+)");

            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            string start = "";
            string end = "";

            var matcher = split.Matches(firstInput);
            foreach (Match match in matcher)
            {
                start = match.Groups[1].Value.ToString();
                end = match.Groups[5].Value.ToString();
            }

            var solution = new StringBuilder();

            int indexerStart = 0;
            int indexerEnd = 0;

            for (int i = 0; i < secondInput.Length; i++)
            {
                int firstOccasion = secondInput.IndexOf(start, indexerStart);
                int secondOccasion = secondInput.IndexOf(end, indexerEnd);
                if (firstOccasion != -1 && secondOccasion != -1)
                {
                    solution.Append(secondInput,
                        firstOccasion + start.Length,
                        secondOccasion - (firstOccasion + start.Length));
                    i = firstOccasion;
                    indexerStart = firstOccasion + 1;
                    indexerEnd = secondOccasion + 1;
                } //e tui ako proraboti si reja tashacite
                else
                {
                    break;
                }
            }
            if (solution.Length > 0)
            {
                Console.WriteLine(solution);
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}