using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pokemon_Dont_Go_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> solution = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long sumOfAllRemoved = 0;

            while (solution.Count > 0)
            {
                int indexer = int.Parse(Console.ReadLine());
                long currentValue = 0;

                if (indexer < 0)
                {
                    currentValue = solution[0];
                    sumOfAllRemoved += currentValue;
                    solution[0] = solution[solution.Count - 1];
                }
                else if (indexer > solution.Count - 1)
                {
                    currentValue = solution[solution.Count - 1];
                    sumOfAllRemoved += currentValue;
                    solution[solution.Count - 1] = solution[0];
                }
                else
                {
                    currentValue = solution[indexer];
                    sumOfAllRemoved += currentValue;
                    solution.RemoveAt(indexer);
                }

                for (int cycle = 0; cycle < solution.Count; cycle++)
                {
                    if (solution[cycle] <= currentValue)
                    {
                        solution[cycle] += currentValue;
                    }
                    else
                    {
                        solution[cycle] -= currentValue;
                    }
                }
            }
            Console.WriteLine(sumOfAllRemoved);
        }
    }
}