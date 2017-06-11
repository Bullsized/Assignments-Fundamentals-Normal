using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');

            int leftEqual = 0;
            int rightEqual = 0;

            int smallerArray = Math.Min(firstLine.Length, secondLine.Length);

            for (int cycle1 = 0; cycle1 < smallerArray; cycle1++)
            {
                if (firstLine[cycle1].Contains(secondLine[cycle1]))
                {
                    leftEqual++;
                }
                else
                {
                    break;
                }
            }

            for (int cycle2 = 0; cycle2 < smallerArray; cycle2++)
            {
                if (firstLine[firstLine.Length - 1 - cycle2].Contains(secondLine[secondLine.Length - 1 - cycle2]))
                {
                    rightEqual++;
                }
                else
                {
                    break;
                }
            }
           

            if (leftEqual > rightEqual)
            {
                Console.WriteLine(leftEqual);
            }
            else if (rightEqual >= leftEqual)
            {
                Console.WriteLine(rightEqual);
            }
            else
            {
                Console.WriteLine(0);
            }
        }      
    }
}