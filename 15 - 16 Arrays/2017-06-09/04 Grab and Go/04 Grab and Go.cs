using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchNum = int.Parse(Console.ReadLine());
            long sum = 0;

            List<int> putTheIndexes = new List<int>();
            for (int cycle = 0; cycle < lineOfDigits.Length; cycle++)
            {
                if (lineOfDigits[cycle] == searchNum)
                {
                    putTheIndexes.Add(cycle);
                }
            }
            if (putTheIndexes.Count > 0)
            {
                for (int cycle2 = 0; cycle2 < putTheIndexes[putTheIndexes.Count - 1]; cycle2++)
                {
                    sum += lineOfDigits[cycle2];
                }

                Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }          
        }
    }
}