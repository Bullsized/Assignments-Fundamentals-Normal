using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOfInputs = Console.ReadLine()
                .Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            decimal totalSum = 0;

            for (int cycle1 = 0; cycle1 < lineOfInputs.Length; cycle1++)
            {
                decimal answer = 0;
                char[] currentInput = lineOfInputs[cycle1].ToCharArray();
                char startLetter = currentInput[0];
                char endLetter = currentInput[currentInput.Length - 1];

                string middleDigitString = lineOfInputs[cycle1].Substring(1, lineOfInputs[cycle1].Length - 2);

                decimal middleDigit = decimal.Parse(middleDigitString);

                if (startLetter == char.ToUpper(startLetter))
                {
                    int index = char.ToUpper(startLetter) - 64;
                    answer += middleDigit / index;
                }
                else                                       
                {
                    int index = char.ToUpper(startLetter) - 64;
                    answer += middleDigit * index;
                }

                if (endLetter == char.ToUpper(endLetter))
                {
                    int index = char.ToUpper(endLetter) - 64;
                    answer -= index;
                }
                else
                {
                    int index = char.ToUpper(endLetter) - 64;
                    answer += index;
                }

                totalSum += answer;
            }

            Console.WriteLine("{0:f2}", totalSum);
        }
    }
}