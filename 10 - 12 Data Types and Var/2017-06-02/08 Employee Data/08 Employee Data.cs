using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int emplNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}" + Environment.NewLine +
                $"Last name: {lastName}" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine +
                $"Gender: {gender}" + Environment.NewLine +
                $"Personal ID: {personalID}" + Environment.NewLine +
                $"Unique Employee number: {emplNum}");
        }
    }
}