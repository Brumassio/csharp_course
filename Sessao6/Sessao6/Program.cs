using System.Globalization;

namespace Sessao6 {
    internal class Program {
        static void Main(string[] args) {
            /*
            Console.WriteLine("------------------------------\nExércício de fixação -> vetores\n");
            RegistroPensionato[] reg = new RegistroPensionato[10];

            Console.WriteLine("Digite a quantidade de quartos a ser reservada: ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++) {
                Console.WriteLine($"\nESTUDANTE {i+1}\n");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto (até 10): ");
                int quarto = int.Parse(Console.ReadLine());

                reg[quarto -1] = new RegistroPensionato {Nome =nome, Email = email, Quarto = quarto };
            }

            Console.WriteLine("Quartos ocupados");
            for (int i = 0;i < 10; i++) {
                if (reg[i] != null) {
                    Console.WriteLine(reg[i]);
                }
            }

            Console.WriteLine("------------------------------\nExércício de fixação -> Listas\n");
            List<Employee> empl = new List<Employee>();

            Console.Write("How many Employees will be registered ? ");
            int qtde = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine($"\nEmployee #{i+1}:");
                Console.Write("ID:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empl.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the Employee id that will have salary increase:");
            int idEmp = int.Parse(Console.ReadLine());
            if(empl.Exists(x => x.Id == idEmp)) {
                Console.Write("Enter the percentage:");
                double percent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                empl.Find(x => x.Id == idEmp).IncreaseSalary(percent);

            }
            else {
                Console.WriteLine("\nThis id does not exist !!");
            }
            Console.WriteLine("\nUptaded list of Employees:");
            foreach (var item in empl)
            {
                Console.WriteLine(item);
            }
            */
            Console.WriteLine("------------------------------\nExércício de fixação -> Matrizes\n");
            Console.Write("How many lines ? ");
            int lines = int.Parse(Console.ReadLine());
            Console.Write("How many columns ? ");
            int columns = int.Parse(Console.ReadLine());
            int[,] mat = new int[lines, columns]; 

            for(int i = 0; i <lines; i++) {
                string[] values = Console.ReadLine().Split(" ");
                for(int j=0; j<columns; j++) {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <lines; i++) {
                for (int j = 0; j<columns; j++) {
                    if (mat[i,j] == number) {
                        Console.WriteLine($"Position {i},{j}");
                        if (j-1< columns &&  j-1>=0)
                            Console.WriteLine($"Left: {mat[i, j-1]}");
                        if (j+1< columns &&  j+1>=0)
                            Console.WriteLine($"Right: {mat[i,j+1]}");
                        if (i-1< lines &&  i-1>=0)
                            Console.WriteLine($"Up: {mat[i-1,j]}");
                        if (i+1< lines &&  i+1>=0)
                            Console.WriteLine($"Down: {mat[i+1,j]}");
                    }
                }
            }

        }
    }
}
