using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;

            bool lamp = false;

            for (int middleDigit = 0; middleDigit < lineOfDigits.Length; middleDigit++)
            {
                if (middleDigit > 1)
                {
                    for (int checkLeft = 0; checkLeft <= middleDigit - 1; checkLeft++)
                    {
                        sumLeft += lineOfDigits[checkLeft];
                    }
                }
                else if (middleDigit == 1)
                {
                    sumLeft = lineOfDigits[0];
                }

                if (middleDigit != lineOfDigits.Length - 1)
                {
                    for (int checkRight = middleDigit + 1; checkRight < lineOfDigits.Length; checkRight++)
                    {
                        sumRight += lineOfDigits[checkRight];
                    }
                }

                if (sumLeft == 0 && sumRight == 0)
                {
                    Console.WriteLine(sumRight);
                    lamp = true;
                    break;
                }
                else if (sumLeft == sumRight)
                {
                    Console.WriteLine(middleDigit);
                    lamp = true;
                    break;
                }
                else
                {
                    sumLeft = 0;
                    sumRight = 0;
                }
            }

            if (lamp == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}