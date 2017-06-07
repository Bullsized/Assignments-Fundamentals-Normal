using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            int[] answer = new int[rotation];

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                int insertInTheArray = int.Parse(Console.ReadLine());
                answer[cycle] = insertInTheArray;
            }

            int[] realAnswer = answer.Reverse().ToArray();

            Console.WriteLine(string.Join(" ", realAnswer));
        }
    }
}