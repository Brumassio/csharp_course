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

            Console.WriteLine();
            Console.WriteLine("Segundo Exercício de fixação -> Classe abstrata !");
            List<TaxPayer> list2 = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers:");
            int taxPayers = int.Parse(Console.ReadLine());

            for(int i =0; i<taxPayers;i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data: ");
                Console.Write("Individual or company (i/c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(option  == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list2.Add(new Individual(name,anualIncome,healthExp));
                }
                else if (option == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmp = int.Parse(Console.ReadLine());
                    list2.Add(new Company(name,anualIncome,numberOfEmp));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0.0;
            foreach(TaxPayer taxPayer in list2)
            {
                Console.WriteLine(taxPayer.Name + ": $ "+ taxPayer.Tax().ToString("F2",CultureInfo.InvariantCulture));
                totalTaxes += taxPayer.Tax();
            }
            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
