using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            //70 out of 100, check 02 Pokemon Dont Go 2 for 100 / 100
            List<long> solution = Console.ReadLine().Split().Select(long.Parse).ToList();

            long sumOfAllRemoved = 0;

            while (solution.Count > 0)
            {
                int currentIndex = int.Parse(Console.ReadLine());

                if (currentIndex < 0)
                {
                    sumOfAllRemoved += solution[0];
                    solution.RemoveAt(0);
                    solution.Insert(0, solution.Count - 1);
                    AddOrRemoveValueOfIndex(solution, solution[0]);
                }
                else if (currentIndex >= solution.Count)
                {
                    sumOfAllRemoved += solution[solution.Count - 1];
                    long removed = solution[solution.Count - 1];
                    solution.RemoveAt(solution.Count - 1);
                    solution.Add(solution[0]);
                    AddOrRemoveValueOfIndex(solution, removed);
                }
                else
                {
                    long digitIndexed = solution[currentIndex];
                    sumOfAllRemoved += digitIndexed;
                    solution.RemoveAt(currentIndex);
                    AddOrRemoveValueOfIndex(solution, digitIndexed);
                }

            }
            Console.WriteLine(sumOfAllRemoved);
        }

        private static void AddOrRemoveValueOfIndex(List<long> solution, long digitIndexed)
        {
            for (int cycle = 0; cycle < solution.Count; cycle++)
            {
                if (solution[cycle] <= digitIndexed)
                {
                    solution[cycle] += digitIndexed;
                }
                else
                {
                    solution[cycle] -= digitIndexed;
                }
            }
        }
    }
}