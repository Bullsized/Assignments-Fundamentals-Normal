using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllText("everybody wants some.txt").ToLower()
                .Split(new char[] { '-', '.', '\n', '\r', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> wordAndTimes = new Dictionary<string, int>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (!wordAndTimes.ContainsKey(lines[i]))
                {
                    wordAndTimes[lines[i]] = 1;
                }
                else
                {
                    wordAndTimes[lines[i]]++;
                }
            }

            string[] wordsOnly = wordAndTimes.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => x.Key)
                .ToArray();

            string[] countOnly = wordAndTimes.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => x.Value.ToString())
                .ToArray();

            string arrow = " => ";

            string[] answer = new string[wordsOnly.Length];
            for (int cycle2 = 0; cycle2 < wordsOnly.Length; cycle2++)
            {
                answer[cycle2] = wordsOnly[cycle2] + arrow + countOnly[cycle2];
            }

            //must be a better way to do this!

            File.WriteAllLines("everybody words count.txt", answer);

        }
    }
}