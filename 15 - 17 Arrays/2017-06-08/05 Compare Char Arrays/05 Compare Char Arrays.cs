using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondLine = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstLine.Length > secondLine.Length)
            {
                Console.WriteLine(string.Join("", secondLine));
                Console.WriteLine(string.Join("", firstLine));

            }
            else if (firstLine.Length < secondLine.Length)
            {
                Console.WriteLine(string.Join("", firstLine));
                Console.WriteLine(string.Join("", secondLine));
            }
            else if (firstLine.Length == secondLine.Length)
            {
                for (int i = 0; i < firstLine.Length; i++)
                {
                    if (firstLine[i] > secondLine[i])
                    {
                        Console.WriteLine(string.Join("", secondLine));
                        Console.WriteLine(string.Join("", firstLine));
                        break;
                    }
                    if (secondLine[i] > firstLine[i])
                    {
                        Console.WriteLine(string.Join("", firstLine));
                        Console.WriteLine(string.Join("", secondLine));
                        break;
                    }
                }
            }
        }
    }
}