using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotationTimes = int.Parse(Console.ReadLine());

            int[] rotatedArray = new int[lineOfDigits.Length];

            int[] sumArray = new int[lineOfDigits.Length];

            int sumCount = 0;

            while (rotationTimes > 0)
            {
                for (int i = 0; i < lineOfDigits.Length - 1; i++)
                {
                    rotatedArray[0] = lineOfDigits[lineOfDigits.Length - 1];
                    rotatedArray[1 + i] = lineOfDigits[i];
                }
                if (sumCount > 0)
                {
                    if (sumCount == 1)
                    {
                        for (int h = 0; h < lineOfDigits.Length; h++)
                        {
                            sumArray[h] = lineOfDigits[h] + rotatedArray[h];
                        }
                    }
                    else
                    {
                        for (int h = 0; h < lineOfDigits.Length; h++)
                        {
                            sumArray[h] += rotatedArray[h];
                        }
                    }
                }

                Array.Copy(rotatedArray, lineOfDigits, lineOfDigits.Length);

                sumCount++;
                rotationTimes--;
            }

            if (sumCount == 1)
            {
                Console.WriteLine(string.Join(" ", rotatedArray));
            }
            else
            {
                Console.WriteLine(string.Join(" ", sumArray));
            }
        }
    }
}