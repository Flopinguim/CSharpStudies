using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Entidades
{
    public class UsedProduct : Product
    {
        public DateTime manufacture { get; set; }

        public UsedProduct(string name, double price, DateTime manufacture) : base(name,price)
        {
            this.manufacture = manufacture;
        }

        public override string priceTag() => $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {manufacture.ToShortDateString()})";
    }
}
