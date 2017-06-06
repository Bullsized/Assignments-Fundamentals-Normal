using System;

namespace _03_English_NOTLD
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            NameOfTheLastDigit(num);
            switch (NameOfTheLastDigit(Math.Abs(num)))
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
            }
        }

        static long NameOfTheLastDigit(long num)
        {
            long lastNum = num % 10;

            return lastNum;
        }
    }
}