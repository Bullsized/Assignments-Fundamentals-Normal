using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine($"Min = {listOfDigits.Min()}");
            Console.WriteLine($"Max = {listOfDigits.Max()}");
            Console.WriteLine($"Sum = {listOfDigits.Sum()}");
            Console.WriteLine($"Average = {listOfDigits.Average()}");
        }
    }
}