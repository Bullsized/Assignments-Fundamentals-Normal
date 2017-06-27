using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;

            while (count != 3)
            {
                string[] commands = Console.ReadLine().Split();
                try
                {
                    if (commands[0] == "Replace")
                    {
                        int indexOfTheArray = int.Parse(commands[1]);

                        int element = int.Parse(commands[2]);

                        lineOfDigits[indexOfTheArray] = element;
                    }
                    else if (commands[0] == "Print")
                    {
                        int startIndex = int.Parse(commands[1]);

                        int endIndex = int.Parse(commands[2]);

                        for (int cycle = startIndex; cycle <= endIndex; cycle++)
                        {
                            if (cycle == endIndex)
                            {
                                Console.WriteLine(lineOfDigits[cycle]);
                                break;
                            }

                            Console.Write(lineOfDigits[cycle] + ", ");
                        }
                    }
                    else if (commands[0] == "Show")
                    {
                        int showIndex = int.Parse(commands[1]);

                        Console.WriteLine(lineOfDigits[showIndex]);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    count++;
                }
            }

            Console.WriteLine(string.Join(", ", lineOfDigits));
        }
        // indexoutofrange -> the index does not exist
        // formatexception -> the variable is not in a correct format
    }
}
