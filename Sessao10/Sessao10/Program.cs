using Sessao10.Entities;
using System.Globalization;

namespace Sessao10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeiro Exercício de fixação de Herança e Polimorfismo !");
            Console.WriteLine();
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products:");
            int numberProducts = int.Parse(Console.ReadLine());

            for(int i =0; i<numberProducts; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char charAux = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(charAux == 'c')
                {
                    list.Add(new Product(name, price));
                }else if (charAux == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name,price, manufactureDate));
                }else if(charAux == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }

            }

            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine();
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
