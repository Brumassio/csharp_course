using System.Globalization;

namespace Sessao5 {
    internal class Program {
        static void Main(string[] args) {
            ContaBancaria b1;
            Console.WriteLine("Exercício Construtores-this-sobrecarga-encapsulamento\n");
            Console.WriteLine("Entre o número da conta: ");
            int numCont = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)?");
            char aux = char.Parse(Console.ReadLine());
            if(aux == 's') {
                Console.WriteLine("Digite o valor do depósito inicial :");
                double depInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                b1 = new ContaBancaria(numCont, Nome,depInicial);
            }
            else {
                b1 = new ContaBancaria(numCont, Nome);
            }
            Console.WriteLine(b1);
            Console.WriteLine("Digite o valor do depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b1.Deposito(valor);
            Console.WriteLine(b1);

            Console.WriteLine("Digite o valor do saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b1.Saque(valor);
            Console.WriteLine(b1);
        }
    }
}
