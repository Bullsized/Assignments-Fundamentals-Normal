using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationTimes = int.Parse(Console.ReadLine());
        
            int[] sumArray = new int[lineOfDigits.Length];

            for (int i = 0; i < rotationTimes; i++)
            {
                int lastValue = lineOfDigits[lineOfDigits.Length - 1];

                for (int h = lineOfDigits.Length - 1; h > 0; h--)
                {
                    lineOfDigits[h] = lineOfDigits[h - 1];
                }

                lineOfDigits[0] = lastValue;

                for (int g = 0; g < lineOfDigits.Length; g++)
                {
                    sumArray[g] += lineOfDigits[g];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}