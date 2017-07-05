using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02_Extract_Sntcs_by_Keyw
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string pattern = $@"[a-zA-Z0-9,\s]+ {keyWord} [a-zA-Z0-9,\s\-]+"; //needs a better regex!
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();

            for (int i = 0; i < matches.Length; i++)
            {
                string sentence = matches[i].Trim();
                Console.WriteLine(sentence);
            }
        }
    }
}