using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var outputString = string.Empty;
            var punchStrength = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '>')
                {
                    punchStrength += int.Parse(inputString[i + 1].ToString());
                }
                else if (punchStrength > 0)
                {
                    punchStrength--;
                    continue;
                }
                outputString += inputString[i];
            }

            Console.WriteLine(outputString);

            //string input = Console.ReadLine();
            //List<char> solution = new List<char>();

            //for (int cycle = 0; cycle < input.Length; cycle++)
            //{
            //    solution.Add(input[cycle]);
            //}

            //for (int cycle2 = 0; cycle2 < solution.Count; cycle2++)
            //{
            //    if (solution[cycle2] == '>')
            //    {
            //        int power = int.Parse((solution[cycle2 + 1]).ToString());
            //        solution.RemoveRange(cycle2 + 1, power);

            //    }
            //}

            //Console.WriteLine(string.Join("", solution));
        }
    }
}