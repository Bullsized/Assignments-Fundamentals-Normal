using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool lamp = false;

            for (int arrayIndexer = 0; arrayIndexer < answer.Length; arrayIndexer++)
            {
                for (int checkDigit = arrayIndexer + 1; checkDigit < answer.Length; checkDigit++)
                {
                    int sumOfTwoDigits = answer[arrayIndexer] + answer[checkDigit];
                    if (answer.Contains(sumOfTwoDigits))
                    {
                        Console.WriteLine($"{answer[arrayIndexer]} + {answer[checkDigit]} == {sumOfTwoDigits}");
                        lamp = true;
                    }
                }

            }

            if (lamp == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}