using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            char[] plural = word.ToCharArray();

            if (plural[plural.Length - 1] == 'y')
            {
                plural[plural.Length - 1] = 'i';
                Console.Write(string.Join("", plural));
                Console.WriteLine("es");
            }
            else if (plural[plural.Length - 1] == 'o' ||
                plural[plural.Length - 1] == 'h' ||
                plural[plural.Length - 1] == 's' ||
                plural[plural.Length - 1] == 'x' ||
                plural[plural.Length - 1] == 'z')
            {
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }
        }
    }
}