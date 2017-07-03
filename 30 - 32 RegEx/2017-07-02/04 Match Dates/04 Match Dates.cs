using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04_Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRegex = @"\b(?<day>\d{2})([\/.-])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            //whenever using groups with C#, always substract one!            ^ 1 for the delimiter,
            //                                                           even though it's group no.2

            string dates = Console.ReadLine();

            MatchCollection datesMatches = Regex.Matches(dates, toRegex);

            foreach (Match date in datesMatches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}