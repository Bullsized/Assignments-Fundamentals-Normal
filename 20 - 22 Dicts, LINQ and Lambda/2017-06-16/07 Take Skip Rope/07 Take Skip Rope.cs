using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputLine = Console.ReadLine().ToList();

            List<int> whetherOddOrEvenDigits = new List<int>();

            List<char> lettersToDrawFrom = new List<char>();

            List<int> skipList = new List<int>();

            List<int> takeList = new List<int>();

            List<char> decodedMessage = new List<char>();


            for (int cycle1 = 0; cycle1 < inputLine.Count; cycle1++)
            {
                if (48 <= inputLine[cycle1] && inputLine[cycle1] <= 57)
                {
                    whetherOddOrEvenDigits.Add(int.Parse(inputLine[cycle1].ToString()));
                }
                else
                {
                    lettersToDrawFrom.Add(inputLine[cycle1]);
                }
            }

            for (int cycle2 = 0; cycle2 < whetherOddOrEvenDigits.Count; cycle2++)
            {
                if (cycle2 % 2 == 0)
                {
                    takeList.Add(whetherOddOrEvenDigits[cycle2]);
                }
                else
                {
                    skipList.Add(whetherOddOrEvenDigits[cycle2]);
                }
            }

            int addingSkipCount = 0;

            string answerMessage = string.Empty;

            for (int cycle3 = 0; cycle3 < Math.Max(takeList.Count, skipList.Count); cycle3++)
            {
                List<char> takeSkipList = lettersToDrawFrom
                    .Skip(addingSkipCount)
                    .Take(takeList[cycle3])
                    .ToList();
                Console.Write(string.Join("", takeSkipList));
                addingSkipCount += takeList[cycle3] + skipList[cycle3];
            }

            Console.WriteLine();
        }
    }
}