using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_Array_oS
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] solution = Console.ReadLine().Split(' ').ToArray();

            string[] realSolution = solution.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", realSolution));
        }
    }
}