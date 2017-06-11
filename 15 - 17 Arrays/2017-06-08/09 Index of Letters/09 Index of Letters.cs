using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] input = Console.ReadLine().ToLower().ToCharArray();

            for (int cycle1 = 0; cycle1 < input.Length; cycle1++)
            {
                for (int cycle2 = 0; cycle2 < alphabet.Length; cycle2++)
                {
                    if (input[cycle1] == alphabet[cycle2])
                    {
                        Console.WriteLine(input[cycle1] + " -> " + cycle2);
                    }
                }
            }
        }
    }
}