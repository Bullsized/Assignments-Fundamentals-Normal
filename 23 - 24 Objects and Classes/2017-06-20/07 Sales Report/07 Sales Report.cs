using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sales_Report
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> answer = new SortedDictionary<string, decimal>();

            for (int cycle = 0; cycle < rotation; cycle++)
            {
                string[] inputParameters = Console.ReadLine().Split();

                if (!answer.ContainsKey(inputParameters[0]))
                {
                    answer.Add(inputParameters[0],
                        decimal.Parse(inputParameters[2]) * decimal.Parse(inputParameters[3]));
                }
                else
                {
                    answer[inputParameters[0]] += decimal.Parse(inputParameters[2]) * decimal.Parse(inputParameters[3]);
                }
            }

            foreach (var kvp in answer)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }


        }

    }

    //public class Shop
    //{
    //    public string Quality { get; set; }
    //    public string Product { get; set; }
    //    public decimal Price { get; set; }
    //    public decimal Quantity { get; set; }
    //    public decimal Total
    //    {
    //        get
    //        {
    //            return Price * Quantity;
    //        }
    //    }

    //}
}