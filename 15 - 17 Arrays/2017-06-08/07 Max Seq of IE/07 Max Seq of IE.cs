using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Max_Seq_of_IE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int start = 0;
            int len = 1;

            int bestPosition = 0;
            int bestLen = 1;

            for (int i = 1; i < listOfDigits.Length; i++)
            {
                if (listOfDigits[i] > listOfDigits[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestPosition = start;
                    }
                }
                else
                {
                    if (len > bestLen)
                    {
                        bestPosition = start;
                        bestLen = len;
                    }
                    start = i;
                    len = 1;
                }
            }

            for (int i = bestPosition; i < bestPosition + bestLen; i++)
            {
                Console.Write(listOfDigits[i] + " ");
            }

            Console.WriteLine();
        }
    }
}