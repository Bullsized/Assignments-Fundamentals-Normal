﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Max_Sequence_of_EE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            int counter = 1;
            int start = 0;

            int bestCounter = 1;
            int bestStart = 0;

            for (int cycle = 1; cycle < listOfDigits.Count; cycle++)
            {
                if (listOfDigits[cycle - 1] == listOfDigits[cycle])
                {
                    counter++;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        bestStart = start;
                    }
                }
                else
                {
                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        bestStart = start;
                    }
                    start = cycle;
                    counter = 1;
                }
            }

            for (int cycle2 = bestStart; cycle2 < bestCounter + bestStart; cycle2++)
            {
                Console.Write($"{listOfDigits[cycle2]} ");
            }

            Console.WriteLine();
        }
    }
}