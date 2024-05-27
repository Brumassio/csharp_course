using Sessao11.Entities;
using Sessao11.Entities.Exceptions;
using System.Globalization;

namespace Sessao11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Exercício de fixação de tratamento de Exceções ");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(number,holder,balance,limit);

                Console.WriteLine();
                Console.WriteLine(acc);
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                acc.Withdraw(amount);
                Console.WriteLine("New balance: "+ acc.Balance);
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+ e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: "+ e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error:" + e.Message);
            }

        }
    }
}
