﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_Concate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            string evenOrOdd = Console.ReadLine();
            int numberOfInputWords = int.Parse(Console.ReadLine());

            List<string> allWords = new List<string>();

            for (int i = 1; i <= numberOfInputWords; i++)
            {
                string currentWord = Console.ReadLine();
                if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        allWords.Add(currentWord);
                    }
                }
                else if (evenOrOdd == "odd")
                {
                    if (i % 2 != 0)
                    {
                        allWords.Add(currentWord);
                    }
                }
            }

            Console.WriteLine(string.Join(delimiter, allWords));
        }
    }
}