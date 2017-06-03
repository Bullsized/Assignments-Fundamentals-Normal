using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Balanced_Brackets_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            string lastBracket = string.Empty;
            string balance = "BALANCED";

            for (int i = 0; i < numberOfInputs; i++)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "(")
                {
                    if (lastBracket == "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    lastBracket = "(";
                }
                if (currentInput == ")")
                {
                    if (lastBracket != "(")
                    {
                        balance = "UNBALANCED";
                        break;
                    }
                    lastBracket = ")";
                }
            }
            if (lastBracket == "(")
            {
                balance = "UNBALANCED";
            }

            Console.WriteLine(balance);
        }
    }
}