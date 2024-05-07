using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao6 {
    internal class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id=id;
            Name=name;
            Salary=salary;
        }

        public void IncreaseSalary(double percentage) {
            double aux = Salary * (percentage/100);
            Salary +=aux;
        }

        public override string ToString() {
            return Id.ToString()+", "+Name+", "+ Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
