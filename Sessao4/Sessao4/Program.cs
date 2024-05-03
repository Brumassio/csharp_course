using System.Diagnostics.Contracts;
using System.Globalization;

namespace Sessao4 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("-------------------------------------\nPrimeiro exercício de fixação");
            Retangulo ret = new Retangulo();
            Console.WriteLine("Digite a Altura:");
            ret.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Largura:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"ÁREA : {ret.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO: {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("-------------------------------------\nSegundo exercício de fixação");
            Funcionario f1 = new Funcionario();
            Console.WriteLine("Digite a Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a Salário Bruto:");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o Imposto:");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados Atualizados: "+ f1);
            Console.WriteLine("Digite a porcentagem para aumentar o salário");
            double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(percent);

            Console.WriteLine("Dados Atualizados: "+ f1);

            Console.WriteLine("-------------------------------------\nTerceiro exercício de fixação");
            Aluno a1 = new Aluno();
            Console.WriteLine("Digite o nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota 1");
            a1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 2");
            a1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a nota 3");
            a1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a1.aprovacao();
        }
    }
}
