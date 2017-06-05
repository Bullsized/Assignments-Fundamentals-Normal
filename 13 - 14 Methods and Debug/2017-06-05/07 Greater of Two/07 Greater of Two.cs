using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Greater_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int": IntMethod(); break;
                case "char": CharMethod(); break;
                case "string": StringMethod(); break;
            }
        }

        private static void StringMethod()
        {
           string first = Console.ReadLine(); 
           string second = Console.ReadLine();

            if (first.CompareTo(second) >= 0) Console.WriteLine(first);
            else Console.WriteLine(second);
        }

        private static void CharMethod()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            if (first > second) Console.WriteLine(first);
            else Console.WriteLine(second);
        }

        private static void IntMethod()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first > second) Console.WriteLine(first);
            else Console.WriteLine(second);
        }
    }
}