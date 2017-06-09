using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Seq_of_EE
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bestStart = 0;
            int bestLenght = 0;
            int start = listOfDigits[0];
            int len = 1;

            for (int cycle = 1; cycle <= listOfDigits.Length - 1; cycle++)
            {
                if (start == listOfDigits[cycle])
                {
                    len++;
                    if (len > bestLenght)
                    {
                        bestStart = listOfDigits[cycle];
                        bestLenght = len;
                    }
                }
                else
                {
                    start = listOfDigits[cycle];
                    len = 1;
                }
            }

            while (bestLenght > 0)
            {
                Console.Write(bestStart + " ");
                bestLenght--;
            }
            Console.WriteLine();
        }
    }
}