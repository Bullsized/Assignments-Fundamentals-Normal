using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine().ToUpper();

            Regex toRegex = new Regex(@"([A-Za-z\W_]+)(\d+)");
            MatchCollection splitToUpper = toRegex.Matches(inputLine);

            StringBuilder result = new StringBuilder();

            foreach (Match match in splitToUpper)
            {
                var text = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);
                for (int cycle = 0; cycle < count; cycle++)
                {
                    result.Append(text);
                }
            }


            Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            Console.WriteLine(result);
            
            
            //var letsSplitToCharArray = inputLine.ToCharArray();

            //var distinctList = letsSplitToCharArray.Distinct().ToArray();

            //int uniqueCount = 0;

            //int kuraMu = distinctList.Distinct().Count();

            //for (int cycle = 0; cycle < distinctList.Length; cycle++)
            //{
            //    if (distinctList[cycle] < 48 || distinctList[cycle] > 57)
            //    {
            //        uniqueCount++;
            //    }
            //}

            //StringBuilder solution = new StringBuilder();

            //string secondSolution = string.Empty;

            //foreach (Match upper in splitToUpper)
            //{
            //    solution = solution.Append(upper.Groups[1].Value.ToString().ToUpper(),
            //        solution.Length,
            //        int.Parse(upper.Groups[2].Value));

            //    for (int cycle3 = 0; cycle3 < int.Parse(upper.Groups[2].Value); cycle3++)
            //    {
            //        secondSolution += upper.Groups[1].Value.ToString();
            //    }
            //}


        }
    }
}