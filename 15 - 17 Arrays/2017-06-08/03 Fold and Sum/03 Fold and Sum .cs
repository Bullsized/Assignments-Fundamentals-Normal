using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int inHalf = lineOfDigits.Length / 2;
            
            int[] answer = new int[inHalf];

            int inQuarter = lineOfDigits.Length / 4;

            for (int i = 0; i < inQuarter; i++)
            {
                answer[i] = lineOfDigits[inQuarter - i - 1] + lineOfDigits[inQuarter + i];
            }
            for (int h = 0; h < inQuarter; h++)
            {
                answer[inQuarter + h] = lineOfDigits[3 * inQuarter + h] + lineOfDigits[3 * inQuarter - 1 - h];
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}