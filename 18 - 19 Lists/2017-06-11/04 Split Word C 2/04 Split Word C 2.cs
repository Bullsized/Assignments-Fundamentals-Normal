﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Split_Word_C_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
             .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, 
             StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            List<string> upperWords = new List<string>();
            List<string> lowerWords = new List<string>();
            List<string> mixedWords = new List<string>();

            for (int cycle = 0; cycle < words.Count; cycle++)
            {
                bool onlyUpperCase = true;
                bool onlyLowerCase = true;

                foreach (char letter in words[cycle])
                {
                    if (char.IsUpper(letter))
                    {
                        onlyLowerCase = false;
                    }
                    else if (char.IsLower(letter))
                    {
                        onlyUpperCase = false;
                    }
                    else
                    {
                        onlyLowerCase = false;
                        onlyUpperCase = false;
                    }
                }

                if (onlyUpperCase == true && onlyLowerCase == false)
                {
                    upperWords.Add(words[cycle]);
                }
                else if (onlyUpperCase == false && onlyLowerCase == true)
                {
                    lowerWords.Add(words[cycle]);
                }
                else if (onlyUpperCase == false && onlyLowerCase == false)
                {
                    mixedWords.Add(words[cycle]);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperWords)}");
        }
    }
}