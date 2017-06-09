using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Мanipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lineOfStrings = Console.ReadLine().Split();
            int rotation = int.Parse(Console.ReadLine());
            string[] copyLineOfStrings = new string[lineOfStrings.Length];

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                string command = Console.ReadLine();

                bool lamp = false;

                if (command == "Reverse")
                {
                    copyLineOfStrings = lineOfStrings.Reverse().ToArray();
                }
                else if (command == "Distinct")
                {
                    copyLineOfStrings = lineOfStrings.Distinct().ToArray();
                }
                else
                {
                    string[] listOfCommands = command.Split(' ').ToArray();
                    int indexToReplace = int.Parse(listOfCommands[1]);
                    lineOfStrings[indexToReplace] = listOfCommands[2];
                    lamp = true;
                }

                if (copyLineOfStrings.Length < lineOfStrings.Length)
                {
                    Array.Resize(ref lineOfStrings, copyLineOfStrings.Length);
                }

                if (lamp != true)
                {
                    Array.Copy(copyLineOfStrings, lineOfStrings, copyLineOfStrings.Length);
                }
            }

            Console.WriteLine(string.Join(", ", lineOfStrings));
        }
    }
}
