using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] inputDetails = Console.ReadLine().Split();

            while (inputDetails[0] != "END")
            {
                if (inputDetails.Length == 3) //add to the dict
                {
                    phonebook[inputDetails[1]] = inputDetails[2];
                }
                else //find
                {
                    if (phonebook.ContainsKey(inputDetails[1]))
                    {
                        Console.WriteLine($"{inputDetails[1]} -> {phonebook[inputDetails[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {inputDetails[1]} does not exist.");
                    }
                }

                inputDetails = Console.ReadLine().Split();
            }
        }
    }
}