using Sessao9.Entities;
using Sessao9.Entities.Enums;
using System.Globalization;

namespace Sessao9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            DateTime date;
            Console.Write("Birth date (DD/MM/YYYY):");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data :");
            Console.Write("Status (PedingPayment/Processing/Shipped/Delivered):");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client cl = new Client(name, email, date);

            Console.Write("How many items to this order? ");
            int qtde = int.Parse(Console.ReadLine());

            DateTime moment = DateTime.Now;

            Order ord = new Order(moment, os, cl);

            for (int i = 0; i<qtde; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                ord.Items.Add(new OrderItem(quantity, price, new Product(productName, price)));
            }

            Console.WriteLine(ord);

        }
    }
}
