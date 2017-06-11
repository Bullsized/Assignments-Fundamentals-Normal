using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            char[] secondLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string firstWord = string.Join("", firstLine);
            string secondWord = string.Join("", secondLine);

            int result = string.Compare(firstWord, secondWord);

            if (result <= 0)
            {
                Console.WriteLine(firstWord);
                Console.WriteLine(secondWord);
            }
            else
            {
                Console.WriteLine(secondWord);
                Console.WriteLine(firstWord);
            }
        }
    }
}