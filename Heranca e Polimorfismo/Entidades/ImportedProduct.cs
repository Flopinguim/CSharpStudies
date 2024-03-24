using System.Globalization;

namespace Heranca_e_Polimorfismo.Entidades
{
    public class ImportedProduct : Product
    {
        public double customFee { get; set; }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            this.customFee = customFee;
        }

        public override string priceTag() => $"{Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)}  (Custms fee: $ {customFee.ToString("F2", CultureInfo.InvariantCulture)})";


        public double totalPrice() => Price + customFee;

    }
}
