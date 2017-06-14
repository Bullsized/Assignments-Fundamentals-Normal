using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            int half = lineOfDigits.Count / 2;

            int quarter = lineOfDigits.Count / 4;

            int[] topLeft = lineOfDigits.Take(quarter).Reverse().ToArray();

            int[] topRight = lineOfDigits.Skip(3 * quarter).Reverse().ToArray();

            List<int> top = topLeft.Concat(topRight).ToList();

            List<int> bottom = lineOfDigits.Skip(quarter).Take(2 * quarter).ToList();

            var answer = top.Select((x, index) => x + bottom[index]);

            Console.WriteLine(string.Join(" ", answer));

        }
    }
}