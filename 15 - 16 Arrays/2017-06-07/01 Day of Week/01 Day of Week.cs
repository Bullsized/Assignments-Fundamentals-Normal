using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] answer = new string[]
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            switch (n)
            {
                case 1: Console.WriteLine(answer[0]); break;
                case 2: Console.WriteLine(answer[1]); break;
                case 3: Console.WriteLine(answer[2]); break;
                case 4: Console.WriteLine(answer[3]); break;
                case 5: Console.WriteLine(answer[4]); break;
                case 6: Console.WriteLine(answer[5]); break;
                case 7: Console.WriteLine(answer[6]); break;
                default: Console.WriteLine("Invalid Day!"); break;
            }
        }
    }
}