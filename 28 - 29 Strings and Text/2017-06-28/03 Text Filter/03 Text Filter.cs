using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ' ', ',' }, 
                StringSplitOptions.RemoveEmptyEntries);
            string textToReplace = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (textToReplace.Contains(word))
                {
                    textToReplace = textToReplace.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(textToReplace);
        }
    }
}