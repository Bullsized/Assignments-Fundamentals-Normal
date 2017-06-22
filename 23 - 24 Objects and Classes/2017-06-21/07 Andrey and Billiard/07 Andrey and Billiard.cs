using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Andrey_and_Billiard
{
    public class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> itemsPrice = new Dictionary<string, decimal>();

            for (int cycle1 = 0; cycle1 < amount; cycle1++)
            {
                string[] inputLine = Console.ReadLine().Split('-');

                var item = inputLine[0];
                var priceOfTheItem = decimal.Parse(inputLine[1]);

                if (!itemsPrice.ContainsKey(item))
                {
                    itemsPrice.Add(item, priceOfTheItem);
                }

                itemsPrice[item] = priceOfTheItem;

            }

            string secondInputLine = Console.ReadLine();

            List<Customers> DallasBuyersClub = new List<Customers>();

            while (secondInputLine != "end of clients")
            {
                string[] secondInput = secondInputLine.Split('-', ',').ToArray();
                string client = secondInput[0];
                string order = secondInput[1];
                decimal qtity = decimal.Parse(secondInput[2]);

                if (!itemsPrice.ContainsKey(order))
                {
                    secondInputLine = Console.ReadLine();
                    continue;
                }
                else
                {
                    Customers currentCustomer = new Customers()
                    {
                        Name = client,
                        Item = order,
                        Quantity = qtity,
                        Bill = qtity * itemsPrice[order]
                    };

                    DallasBuyersClub.Add(currentCustomer);

                }

                secondInputLine = Console.ReadLine();
            }

            decimal totalBill = 0;

            foreach (var client in DallasBuyersClub.OrderBy(x => x.Name))
            {
                Console.WriteLine(client.Name);
                Console.WriteLine("-- {0} - {1}", client.Item, client.Quantity);
                Console.WriteLine("Bill: {0:f2}", client.Bill);
                totalBill += client.Bill;
            }
            Console.WriteLine("Total bill: {0}",totalBill);
        }
    }
}