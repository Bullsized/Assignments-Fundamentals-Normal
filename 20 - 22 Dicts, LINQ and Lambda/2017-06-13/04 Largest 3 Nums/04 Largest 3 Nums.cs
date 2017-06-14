using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Largest_3_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", lineOfDigits));
        }
    }
}