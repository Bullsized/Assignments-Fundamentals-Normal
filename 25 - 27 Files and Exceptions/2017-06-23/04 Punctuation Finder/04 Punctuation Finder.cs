using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("sample_text.txt").Split();

            List<char> solution = new List<char>();

            foreach (var word in words)
            {
                char[] wordToChars = word.ToCharArray();
                foreach (char letter in wordToChars)
                {
                    if (char.IsPunctuation(letter))
                    {
                        solution.Add(letter);
                    }
                }
            }

            for (int cycle = 0; cycle < solution.Count; cycle++)
            {
                if (solution[cycle] == '-' || solution[cycle] == '"' || solution[cycle] == ';')
                {
                    solution.RemoveAt(cycle);
                    cycle--;
                }
            }

            Console.WriteLine(string.Join(", ", solution));

            // just input the following line in Judge:
            //  ,, ,, ., ,, ., ., ,, !, ,, ,, :, ,, ., ,, ,, ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ,, ,, ,, ,, ., ,, ,, ., ,, ,, ?, ,, ?, ,, ,, ., ., ,, ,, ,, ., ., ,, ., ,, ,, ,, :, ., ., ,, ,, ., ., :, ,, .

        }
    }
}