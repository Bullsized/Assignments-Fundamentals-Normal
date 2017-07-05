using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToReplace = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(wordToReplace, new string('*', wordToReplace.Length));

            Console.WriteLine(sentence);
        }
    }
}