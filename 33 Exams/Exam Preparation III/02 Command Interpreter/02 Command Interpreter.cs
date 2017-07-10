using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfString = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] commands = inputLine.Split(' ');
                string initialCommand = commands[0];

                List<string> workingList = new List<string>();

                if (initialCommand == "reverse")
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);

                    if (start < 0 || start >= listOfString.Count || start + count > listOfString.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    for (int cycle1 = start; cycle1 < start + count; cycle1++)
                    {
                        workingList.Add(listOfString[cycle1]);
                    }

                    workingList.Reverse();

                    int zeroCounter = 0;

                    for (int cycle2 = start; cycle2 < start + count; cycle2++)
                    {
                        listOfString[cycle2] = workingList[zeroCounter];
                        zeroCounter++;
                    }

                }
                else if (initialCommand == "sort")
                {
                    int start = int.Parse(commands[2]);
                    int count = int.Parse(commands[4]);

                    if (start < 0 || start >= listOfString.Count || start + count > listOfString.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    for (int cycle1 = start; cycle1 < start + count; cycle1++)
                    {
                        workingList.Add(listOfString[cycle1]);
                    }

                    workingList.Sort();

                    int zeroCounter = 0;

                    for (int cycle2 = start; cycle2 < start + count; cycle2++)
                    {
                        listOfString[cycle2] = workingList[zeroCounter];
                        zeroCounter++;
                    }

                }
                else if (initialCommand == "rollLeft")
                {
                    int count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    if (count > listOfString.Count)
                    {
                        int howManyTimesToRoll = count % listOfString.Count;

                        for (int cycle3 = 0; cycle3 < howManyTimesToRoll; cycle3++)
                        {
                            listOfString.Add(listOfString[0]);
                            listOfString.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int cycle3 = 0; cycle3 < count; cycle3++)
                        {
                            listOfString.Add(listOfString[0]);
                            listOfString.RemoveAt(0);
                        }
                    }
                }
                else if (initialCommand == "rollRight")
                {
                    int count = int.Parse(commands[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        inputLine = Console.ReadLine();
                        continue;
                    }

                    if (count > listOfString.Count)
                    {
                        int howManyTimesToRoll = count % listOfString.Count;

                        for (int cycle3 = 0; cycle3 < howManyTimesToRoll; cycle3++)
                        {
                            listOfString.Insert(0, listOfString[listOfString.Count - 1]);
                            listOfString.RemoveAt(listOfString.Count - 1);
                        }
                    }
                    else
                    {
                        for (int cycle3 = 0; cycle3 < count; cycle3++)
                        {
                            listOfString.Insert(0, listOfString[listOfString.Count - 1]);
                            listOfString.RemoveAt(listOfString.Count - 1);
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", listOfString)}]");

        }
    }
}