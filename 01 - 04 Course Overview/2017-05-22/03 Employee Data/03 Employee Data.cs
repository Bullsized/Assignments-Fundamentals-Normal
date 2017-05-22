using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine +
                $"Employee ID: {employeeID:D8}" + Environment.NewLine + 
                $"Salary: {salary:f2}");
        }
    }
}