using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringInput = Console.ReadLine().Split('|').ToList();

            List<int> reversedNums = new List<int>();

            for (int i = stringInput.Count - 1; i >= 0; i--)
            {
                List<int> nums = stringInput[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                foreach (int num in nums)
                {
                    reversedNums.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", reversedNums));
        }
    }
}