using System.Globalization;

namespace IntroducaoClasse {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("---------------------------------------\nPrimeiro exercício");
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite os dados da primeira Pessoa\n");
            Console.WriteLine("NOME:");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("IDADE:");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda Pessoa\n");
            Console.WriteLine("NOME:");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("IDADE:");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            Console.WriteLine("---------------------------------------\nSegundo exercício");
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário\n");
            Console.WriteLine("Digite o nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo funcionário\n");
            Console.WriteLine("Digite o nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario_medio = (f1.Salario +f2.Salario)/2;
            Console.WriteLine($"Salário médio: {salario_medio.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
