using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            //A, E, I, O, U, and sometimes Y
            char input = char.Parse(Console.ReadLine());
            bool lamp = false;

            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y': Console.WriteLine("vowel"); lamp = true; break;
            }

            if (48 <= input && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (!lamp)
            {
                Console.WriteLine("other");
            }
        }
    }
}