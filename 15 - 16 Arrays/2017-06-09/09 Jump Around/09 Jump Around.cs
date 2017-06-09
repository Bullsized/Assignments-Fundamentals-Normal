using System;
using System.Linq;

namespace _09_Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = lineOfDigits[0];

            for (int cycle = 0; cycle < lineOfDigits.Length; cycle++)
            {
                bool possibleTransfer = false;

                if (cycle + lineOfDigits[cycle] < lineOfDigits.Length)
                {
                    sum += lineOfDigits[cycle + lineOfDigits[cycle]];
                    cycle = cycle + lineOfDigits[cycle];
                    possibleTransfer = true;
                }
                else if (0 < cycle - lineOfDigits[cycle])
                {
                    sum += lineOfDigits[cycle - lineOfDigits[cycle]];
                    cycle = cycle - lineOfDigits[cycle];
                    possibleTransfer = true;
                }

                if (possibleTransfer == false)
                {
                    Console.WriteLine(sum);
                    break;
                }

                cycle--;
            }
        }
    }
}