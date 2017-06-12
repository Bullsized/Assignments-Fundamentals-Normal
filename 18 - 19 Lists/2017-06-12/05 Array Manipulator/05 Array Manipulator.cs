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
                    case "shift": lineOfDigits = ShiftMethod(lineOfDigits, lineOfCommands); break;
                    case "sumpairs": lineOfDigits = SumPairsMethod(lineOfDigits); break;
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

        private static List<int> ShiftMethod(List<int> lineOfDigits, List<string> lineOfCommands)
        {
            int positions = int.Parse(lineOfCommands[1]);

            int[] temp = new int[lineOfDigits.Count];

            for (int i = 0; i < lineOfDigits.Count - 1; i++)
            {
                temp[i] = lineOfDigits[i + positions];
            }

            temp[temp.Length - positions] = lineOfDigits[0];

            lineOfDigits = temp.ToList();
            return lineOfDigits;
        }
       
        private static List<int> SumPairsMethod(List<int> lineOfDigits)
        {
            List<int> sumPairs = new List<int>();

            if (lineOfDigits.Count % 2 == 0)
            {
                for (int cycle = 0; cycle < lineOfDigits.Count - 1; cycle++)
                {
                    sumPairs.Add(lineOfDigits[cycle] + lineOfDigits[cycle + 1]);
                    cycle++;
                }
            }
            else
            {
                for (int cycle = 0; cycle < lineOfDigits.Count - 2; cycle++)
                {
                    sumPairs.Add(lineOfDigits[cycle] + lineOfDigits[cycle + 1]);
                    cycle++;
                }
            }
            lineOfDigits.Clear();
            lineOfDigits = sumPairs.ToList();
            return lineOfDigits;
        }
    }
}