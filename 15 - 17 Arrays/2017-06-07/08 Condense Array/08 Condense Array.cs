using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Condense_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = new int[firstArray.Length - 1];

            if (firstArray[0] == 1 && firstArray.Length == 1)
            {
                Console.WriteLine("1 is already condensed to number");
            }
            else
            {
                while (firstArray.Length > 1)
                {
                    for (int cycle = 0; cycle < firstArray.Length - 1; cycle++)
                    {
                        secondArray[cycle] = firstArray[cycle] + firstArray[cycle + 1];
                    }
                    Array.Resize(ref firstArray, firstArray.Length - 1);
                    Array.Copy(secondArray, firstArray, firstArray.Length);
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
        }
    }
}