using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Entidades
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag() => $"{Name} $ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
