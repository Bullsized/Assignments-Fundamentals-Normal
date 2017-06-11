﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            bool[] answer = new bool[range + 1];

            for (int i = 0; i <= range; i++)
            {
                answer[i] = true;
            }

            answer[0] = false; answer[1] = false;

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == true)
                {
                    for (int a = 2; (a * i) <= range; a++)
                    {
                        answer[a * i] = false;
                    }
                }
            }

            for (int j = 2; j <= range; j++)
            {
                if (answer[j] == true)
                {
                    Console.Write(j + " ");
                }
            }

            Console.WriteLine();
        }
    }
}