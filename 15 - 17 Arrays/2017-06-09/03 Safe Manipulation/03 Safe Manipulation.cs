using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 66/100
            string[] lineOfStrings = Console.ReadLine().Split(' ');

            string[] copyLineOfStrings = new string[lineOfStrings.Length];

            string[] listOfCommands = Console.ReadLine().Split(' ');

            while (listOfCommands[0] != "END")
            {
                bool lamp = false;
                if (listOfCommands[0] == "Reverse")
                {
                    copyLineOfStrings = lineOfStrings.Reverse().ToArray();
                }
                else if (listOfCommands[0] == "Distinct")
                {
                    copyLineOfStrings = lineOfStrings.Distinct().ToArray();
                }
                else if (listOfCommands[0] == "Replace")
                {
                    int indexToReplace = int.Parse(listOfCommands[1]);

                    if (indexToReplace >= 0 && indexToReplace < lineOfStrings.Length)
                    {
                        lineOfStrings[indexToReplace] = listOfCommands[2];
                        lamp = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                if (copyLineOfStrings.Length < lineOfStrings.Length)
                {
                    Array.Resize(ref lineOfStrings, copyLineOfStrings.Length);
                }

                if (lamp != true)
                {
                    Array.Copy(copyLineOfStrings, lineOfStrings, copyLineOfStrings.Length);
                }

                listOfCommands = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", lineOfStrings));

        }
    }
}