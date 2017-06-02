using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_C_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int rotation = int.Parse(Console.ReadLine());
            string answer = string.Empty;

            for (int cycle = 1; cycle < rotation; cycle++)
            {
                string input = Console.ReadLine();
                if (cycle % 2 != 0 && oddOrEven == "odd")
                {
                    answer += input;
                    answer += delimiter;
                }
                if (cycle % 2 == 0 && oddOrEven == "even")
                {
                    answer += input;
                    answer += delimiter;
                }
            }
            string finalAnswer = answer.Remove(answer.Length - 1);
            Console.WriteLine(finalAnswer);
        }
    }
}