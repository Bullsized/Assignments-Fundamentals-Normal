using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_MF_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int maxCounter = 0;
            int answerNumber = 0;

            for (int cycle1 = 0; cycle1 < lineOfDigits.Length; cycle1++)
            {
                int currentCounter = 0;

                for (int cycle2 = 0; cycle2 < lineOfDigits.Length; cycle2++)
                {
                    if (lineOfDigits[cycle1] == lineOfDigits[cycle2])
                    {
                        currentCounter++;
                    }
                }
               
                if (currentCounter > maxCounter)
                {
                    maxCounter = currentCounter;
                    answerNumber = lineOfDigits[cycle1];
                }
            }

            Console.WriteLine(answerNumber); 
           
        }
    }
}