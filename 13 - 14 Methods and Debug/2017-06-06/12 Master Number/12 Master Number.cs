using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            bool sumDivided = false;
            bool hasEvenDigit = false;
            bool isPalindrome = false;

            for (int cycle = 1; cycle <= digit; cycle++)
            {
                int[] splittedNum = Array.ConvertAll(cycle.ToString().ToArray(), x => (int)x - 48);
                
                if (splittedNum.Sum() % 7 == 0)
                {
                    sumDivided = true;
                }

                for (int arrayDigits = 0; arrayDigits < splittedNum.Length; arrayDigits++)
                {
                    if (splittedNum[arrayDigits] % 2 == 0)
                    {
                        hasEvenDigit = true;
                        break;
                    }
                }

                for (int palin = 0; palin < splittedNum.Length / 2; palin++)
                {
                    if (splittedNum[0] == splittedNum[splittedNum.Length - palin - 1])
                    {
                        isPalindrome = true;
                    }
                }

                if (sumDivided == true && hasEvenDigit == true && isPalindrome == true)
                {
                    Console.WriteLine(cycle);
                }

                sumDivided = false;
                hasEvenDigit = false;
                isPalindrome = false;
            }
        }
    }
}