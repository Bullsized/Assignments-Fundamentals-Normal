using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]+)?$";

            string input = Console.ReadLine();

            while (input != "Over!")
            {
                bool isMatch = Regex.IsMatch(input, pattern);
                MatchCollection matches = Regex.Matches(input, pattern);

                if (!isMatch)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int messageLength = int.Parse(Console.ReadLine());

                string word = matches[0].Groups[2].Value;

                if (word.Length != messageLength)
                {
                    input = Console.ReadLine();
                    continue;
                }

                char[] leftandrightpart = (matches[0].Groups[1].Value + matches[0].Groups[3].Value).ToCharArray();

                Console.Write(word + " == ");

                char[] characters = word.ToCharArray();

                string result = string.Empty;

                for (int i = 0; i < leftandrightpart.Length; i++)
                {
                    if (!char.IsDigit(leftandrightpart[i]))
                    {
                        result += " ";
                        continue;
                    }

                    int index = int.Parse((leftandrightpart[i]).ToString());

                    if (index >= characters.Length)
                    {
                        result += " ";
                        continue;
                    }
                    else
                    {
                        result += characters[index];
                    }
                }

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}