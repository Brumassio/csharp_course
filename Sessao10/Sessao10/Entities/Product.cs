﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessao10.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; }

        public Product() { }
        public Product(string name, double price)
        {
            Name=name;
            Price=price;
        }

        public virtual string PriceTag() {
            return Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
