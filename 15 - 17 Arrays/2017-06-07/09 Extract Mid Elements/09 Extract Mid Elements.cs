using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Extract_Mid_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] answer = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            if (answer.Length == 1)
            {
                Console.WriteLine($"{{ {answer[0]} }}");
            }
            else if (answer.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {answer[answer.Length / 2 - 1]}, {answer[answer.Length / 2]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {answer[answer.Length / 2 - 1]}, {answer[answer.Length / 2]}, {answer[answer.Length / 2 + 1]} }}");
            }
        }
    }
}