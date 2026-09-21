using FixingDelegates.Entities;
using System.Globalization;

namespace FixingDelegates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();
        Console.Write("Enter Salary: ");
        double SalaryComparison = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        List<Employee> employees = new List<Employee>();

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, email, salary));
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        Console.WriteLine($"Email of people with salary is more than {SalaryComparison:F2}");
        var emails = employees.Where(e => e.Salary > SalaryComparison).Select(e => e.Email).OrderBy(e => e);
        var averageSalary = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).DefaultIfEmpty().Sum();
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }
        Console.WriteLine($"Sum of salaries of people whose name starts with 'M': {averageSalary:F2}");

    }
}