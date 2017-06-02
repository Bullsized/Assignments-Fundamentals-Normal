using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            //this task could be easily done with char[] or List<char>!

            int n = int.Parse(Console.ReadLine());
            string answer = string.Empty;

            for (int cycle = 0; cycle < n; cycle++)
            {
                string toAdd = Console.ReadLine();
                answer += toAdd;
            }
            Console.WriteLine("The word is: " + answer);
        }
    }
}