using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomChars = Console.ReadLine();
            string pattern = Console.ReadLine();

            List<int> listOfIndexes = new List<int>();

            while (true)
            {
                int patternLength = pattern.Length;

                if (patternLength < 1)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomChars);
                    break;
                }

                int continueIndex = 0;
                int index = 0;
                int count = -1;

                while (index != -1)
                {
                    index = randomChars.IndexOf(pattern, continueIndex);
                    continueIndex = index + 1;
                    count++;
                    listOfIndexes.Add(index);
                }

                if (count < 2 || patternLength < 1)
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomChars);                   
                    break;
                }
                //else if (count == 1)                 it is not needed, for even if there is one find
                //{                                    you don't need to replace it.
                //    Console.WriteLine("No shake.");
                //    randomChars = randomChars.Remove(listOfIndexes[0], patternLength);
                //    Console.WriteLine(randomChars);
                //    break;
                //}
                else
                {
                    Console.WriteLine("Shaked it.");
                    randomChars = randomChars.Remove(listOfIndexes[listOfIndexes.Count - 2], patternLength);
                    randomChars = randomChars.Remove(listOfIndexes[0], patternLength);
                    pattern = pattern.Remove(patternLength / 2, 1);
                }

                listOfIndexes.Clear();
            }            
        }
    }
}