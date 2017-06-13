using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<string> lineOfCommands = Console.ReadLine().ToLower().Split().ToList();

            while (lineOfCommands[0] != "print")
            {
                switch (lineOfCommands[0])
                {
                    case "add": AddMethod(lineOfDigits, lineOfCommands); break;
                    case "addmany": AddManyMethod(lineOfDigits, lineOfCommands); break;
                    case "contains": ContainsMethod(lineOfDigits, lineOfCommands); break;
                    case "remove": RemoveMethod(lineOfDigits, lineOfCommands); break;
                    case "shift": ShiftMethod(lineOfDigits, lineOfCommands); break;
                    case "sumpairs": SumPairsMethod(lineOfDigits); break;
                }
                lineOfCommands = Console.ReadLine().ToLower().Split().ToList();
            }

            Console.WriteLine($"[{string.Join(", ", lineOfDigits)}]");

        }

        private static void AddMethod(List<int> lineOfDigits, List<string> lineOfCommands)
        {
            int indexer = int.Parse(lineOfCommands[1]);
            int element = int.Parse(lineOfCommands[2]);
            lineOfDigits.Insert(indexer, element);
        }

        private static void AddManyMethod(List<int> lineOfDigits, List<string> lineOfCommands)
        {
            int indexer = int.Parse(lineOfCommands[1]);
            for (int cycle = 2; cycle < lineOfCommands.Count; cycle++)
            {
                lineOfDigits.Insert(indexer, int.Parse(lineOfCommands[cycle]));
                indexer++;
            }
        }

        private static void ContainsMethod(List<int> lineOfDigits, List<string> lineOfCommands)
        {
            int element = int.Parse(lineOfCommands[1]);
            bool lamp = false;
            for (int cycle = 0; cycle < lineOfDigits.Count; cycle++)
            {
                if (lineOfDigits[cycle] == element)
                {
                    Console.WriteLine(cycle);
                    lamp = true;
                    break;
                }
            }
            if (!lamp)
            {
                Console.WriteLine(-1);
            }
        }

        private static void RemoveMethod(List<int> lineOfDigits, List<string> lineOfCommands)
        {
            int indexer = int.Parse(lineOfCommands[1]);
            lineOfDigits.RemoveAt(indexer);
        }

        private static void ShiftMethod(List<int> lineOfDigits, List<string> lineOfCommands)
        {
            int positions = int.Parse(lineOfCommands[1]);

            int temp = 0;

            for (int i = 0; i < positions; i++)
            {
                temp = lineOfDigits[0];
                lineOfDigits.RemoveAt(0);
                lineOfDigits.Add(temp);
            }         
        }

        private static void SumPairsMethod(List<int> lineOfDigits)
        {
            for (int i = 1; i < lineOfDigits.Count; i += 2)
            {
                lineOfDigits[i - 1] += lineOfDigits[i];
            }
            for (int i = 1; i < lineOfDigits.Count; i++)
            {
                lineOfDigits.RemoveAt(i);
            }          
        }
    }
}