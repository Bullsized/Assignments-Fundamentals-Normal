using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08_Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string bombLine = Console.ReadLine();

            Regex toRegex = new Regex(@"<(.)(.)>");

            MatchCollection letsBombIt = toRegex.Matches(bombLine);

            foreach (Match bombPlace in letsBombIt)
            {
                int startOfTheBlast = bombLine.IndexOf(bombPlace.Value.ToString());

                char leftOne = char.Parse(bombPlace.Groups[1].Value.ToString());
                char rightOne = char.Parse(bombPlace.Groups[2].Value.ToString());

                int blastArea = Math.Abs(leftOne - rightOne);
                
                //bombLine = bombLine.Remove(startOfTheBlast - blastArea, blastArea + 4 + blastArea);
                //bombLine = bombLine.Insert(startOfTheBlast - blastArea, new string('_', 4 + 2 * blastArea));

                string detonation = @".{0," + blastArea + @"}<.{2}>.{0," + blastArea + @"}";
                Regex bombPower = new Regex(detonation);
                string toReplace = bombPower.Match(bombLine).ToString();

                bombLine = bombLine.Replace(toReplace, new string('_', toReplace.Length));
            }

            Console.WriteLine(bombLine);
        }
    }
}