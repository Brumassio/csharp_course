using DELEGATES.Entities;

internal class Program
{
    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }

    private static void Main(string[] args)
    {
        //FUNC EXEMPLO

        //List<Product> products = new List<Product>
        //{
        //    new Product("Computer", 5000.00),
        //    new Product("Mouse", 97.00),
        //    new Product("Keyboard", 100.00)
        //};

        Func<Product, string> func = p => p.Name.ToUpper();

        //List<string> productNames = products.Select(func).ToList();

        // EXEMPLO LINQ --> Pegar os números pares e multiplicar por 10 

        int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

        // Exemplo LINQ 2

        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
        Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

        List<Product> products = new List<Product>
        {
            new Product() { Id = 1, Name = "Computer", Price = 5000.00, Category = c2 },
            new Product() { Id = 2, Name = "Mouse", Price = 97.00, Category = c1 },
            new Product() { Id = 3, Name = "Keyboard", Price = 100.00, Category = c1 },
            new Product() { Id = 4, Name = "Monitor", Price = 1500.00, Category = c2 },
            new Product() { Id = 5, Name = "Printer", Price = 350.00, Category = c3 },
            new Product() { Id = 6, Name = "Scanner", Price = 200.00, Category = c3 },
            new Product() { Id = 7, Name = "Desk", Price = 300.00, Category = c1 },
            new Product() { Id = 8, Name = "Chair", Price = 150.00, Category = c1 }
        };

        var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 300);
        var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("Tier 1 AND Price < 300", r1);
        Print("Category Name = 'Tools'", r2);

    }
}