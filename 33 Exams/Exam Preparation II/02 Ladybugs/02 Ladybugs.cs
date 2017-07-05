using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());

            int[] field = new int[sizeOfTheField];

            for (int cycle = 0; cycle < sizeOfTheField; cycle++)
            {
                field[cycle] = 0;
            }

            int[] filledFields = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int cycle2 = 0; cycle2 < filledFields.Length; cycle2++)
            {
                if (filledFields[cycle2] >= 0 && filledFields[cycle2] < field.Length)
                {
                    field[filledFields[cycle2]] = 1;
                }
            }

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] splitCommands = commands.Split();

                int positionOfTheBug = int.Parse(splitCommands[0]);
                string direction = splitCommands[1];
                int indexesToMove = int.Parse(splitCommands[2]);

                if (positionOfTheBug < 0 || positionOfTheBug >= field.Length || field[positionOfTheBug] != 1)
                {
                    commands = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (direction == "right")
                    {
                        if (positionOfTheBug + indexesToMove >= field.Length)
                        {
                            field[positionOfTheBug] = 0;
                        }
                        else if (field[positionOfTheBug + indexesToMove] == 0)
                        {
                            field[positionOfTheBug] = 0;
                            field[positionOfTheBug + indexesToMove] = 1;
                        }
                        else if (field[positionOfTheBug + indexesToMove] == 1)
                        {
                            field[positionOfTheBug] = 0;
                            while (indexesToMove < field.Length)
                            {
                                indexesToMove += indexesToMove;
                                if (positionOfTheBug + indexesToMove >= field.Length)
                                {
                                    break;
                                }
                                else if (field[positionOfTheBug + indexesToMove] == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    field[positionOfTheBug + indexesToMove] = 1;
                                    break;
                                }

                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        if (positionOfTheBug - indexesToMove <= 0)
                        {
                            field[positionOfTheBug] = 0;
                        }
                        else if (field[positionOfTheBug - indexesToMove] == 0)
                        {
                            field[positionOfTheBug] = 0;
                            field[positionOfTheBug - indexesToMove] = 1;
                        }
                        else if (field[positionOfTheBug - indexesToMove] == 1)
                        {
                            field[positionOfTheBug] = 0;
                            while (indexesToMove < field.Length)
                            {
                                indexesToMove += indexesToMove;
                                if (positionOfTheBug - indexesToMove <= 0)
                                {
                                    break;
                                }
                                else if (field[positionOfTheBug - indexesToMove] == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    field[positionOfTheBug - indexesToMove] = 1;
                                    break;
                                }
                            }
                        }
                    }
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}