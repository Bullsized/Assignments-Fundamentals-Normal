using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Sequence_of_Commands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string[] command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();

            while (!command[0].Equals("stop"))
            {
                PerformAction(array, command);
                PrintArray(array);
                command = Console.ReadLine().Split(ArgumentsDelimiter).ToArray();
            }
        }

        static void PerformAction(long[] listWithDigits, string[] command)
        {
            if (command[0] == "lshift")
            {
                ArrayShiftLeft(listWithDigits);
            }
            else if (command[0] == "rshift")
            {
                ArrayShiftRight(listWithDigits);
            }
            else
            {
                int position = int.Parse(command[1]) - 1;
                int value = int.Parse(command[2]);

                switch (command[0])
                {
                    case "multiply":
                        listWithDigits[position] *= value;
                        break;
                    case "add":
                        listWithDigits[position] += value;
                        break;
                    case "subtract":
                        listWithDigits[position] -= value;
                        break;
                }
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastNumber = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastNumber;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstNumber = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstNumber;
        }

        private static void PrintArray(long[] array)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}