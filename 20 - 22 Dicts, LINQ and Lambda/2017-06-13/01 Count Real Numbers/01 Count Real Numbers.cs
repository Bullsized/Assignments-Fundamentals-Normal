using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> lineOfDigits = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToList();

            SortedDictionary<decimal, int> workInProgress = new SortedDictionary<decimal, int>();

            foreach (var digit in lineOfDigits)
            {
                if (workInProgress.ContainsKey(digit))
                {
                    workInProgress[digit]++;
                }
                else
                {
                    workInProgress.Add(digit, 1);
                }
            }

            foreach (var kvp in workInProgress)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
                
        }
    }
}