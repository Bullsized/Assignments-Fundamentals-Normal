using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arrayTwo = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arrayAnswer = new int[Math.Max(arrayOne.Length, arrayTwo.Length)];

            //1 2 3 4 5
            //2 3

            for (int cycle = 0; cycle < arrayAnswer.Length; cycle++)
            {
                arrayAnswer[cycle] = arrayOne[cycle % arrayOne.Length] + arrayTwo[cycle % arrayTwo.Length];
            }

            Console.WriteLine(string.Join(" ", arrayAnswer));
        }
    }
}