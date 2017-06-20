using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lineOfDigits = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Reverse()
                .ToList();

            for (int cycle1 = 0; cycle1 < lineOfDigits.Count; cycle1++)
            {
                string reversedNum = new string(lineOfDigits[cycle1].ToCharArray().Reverse().ToArray());
                lineOfDigits[cycle1] = reversedNum;
            }

            foreach (var hex in lineOfDigits)
            {
                int value = Convert.ToInt32(hex, 16);
                Console.Write((char)value);
            }

            Console.WriteLine();
        }
    }
}