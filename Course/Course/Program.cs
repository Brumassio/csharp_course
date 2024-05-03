using System.Globalization;
namespace Course {
    internal class Program {
        static void Main(string[] args) {
            sbyte x = 100;
            sbyte y = 20;
            //Console.WriteLine($"o valor de x + y é {x + y}");

            byte n1 = 255;
            n1++;
            //Console.WriteLine($"o valor de n1 é: {n1}"); // estrapolou o limite

            int teste = 2147483647;
            long n4 = 2147483648L;
            int rodrigoGarro = 10;
            //Console.WriteLine($"valor máximo int {teste}, rodrigo garro camisa {rodrigoGarro}");


            bool completo = false;
            //char genero = 'M';
            char letra = '\u0041';
            //Console.WriteLine("\n"+ completo);
            //Console.WriteLine(letra);

            float n5 = 4.5f;
            double n6 = 4.55888;
            //Console.WriteLine($"n6 é {(n6.ToString("F2"))}");

            string nome = "Cássio Ramos";
            //Console.WriteLine($"{nome} brilha muito no curintha");

            object obj1 = 54.5f;
            //Console.WriteLine(obj1);

            //Console.WriteLine($"\nvalor min do int {int.MinValue}");

            //Exercício proposto  1 
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade1 = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            Console.WriteLine("Exercício proposto 1\n----------------------------");
            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é $ {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2.ToString("F2")}");
            Console.WriteLine($"\nRegistro: {idade1} de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

            //Exercício proposto 2
            Console.WriteLine("\nExercício proposto 2\n----------------------------");
            Console.WriteLine("\nEntre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine("\n"+nomeCompleto);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
