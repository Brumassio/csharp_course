using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DELEGATES.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return $" ID: {Id}, Product: {Name}, Price: {Price.ToString("F2",CultureInfo.InvariantCulture)}, {Category?.Name}, {Category?.Tier}";
        }
    }
}
