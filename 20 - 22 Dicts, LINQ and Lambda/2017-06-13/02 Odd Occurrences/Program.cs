﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineOfStrings = Console.ReadLine().ToLower().Split().ToList();

            Dictionary<string, int> answer = new Dictionary<string, int>();

            foreach (var word in lineOfStrings)
            {
                if (answer.ContainsKey(word))
                {
                    answer[word]++;
                }
                else
                {
                    answer[word] = 1;
                }
            }

                string solution = string.Empty;

            foreach (var kvp in answer)
            {
                if (kvp.Value % 2 == 1)
                {
                    solution += kvp.Key;
                    solution += ", ";
                }
            }

            string realSolution = solution.Remove(solution.Length - 2, 2);

            Console.WriteLine(realSolution);
        }
    }
}