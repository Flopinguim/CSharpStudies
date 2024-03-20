using Enumeracao_e_Composicao.Entities.Enums;
using System.Text;

namespace Enumeracao_e_Composicao.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public Client Client { get; set; }

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client cient)
        {
            Moment = moment;
            Status = status;
            Client = cient;
        }         

        public void addItem(OrderItem item) => Items.Add(item);
  
        public void removeItem(OrderItem item) => Items.Remove(item);
        public double total()
        {
            double valorTotal = 0;
            foreach (OrderItem item in Items)
            {
                valorTotal = +item.subTotal();
            }
            return valorTotal;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("ORDER SUMMARY");
            stringBuilder.AppendLine($"Order moment: {Moment}");
            stringBuilder.AppendLine($"Order status: {Status}");
            stringBuilder.AppendLine($"Client: {Client.Name} ({Client.BirthDay}) - {Client.Email}");
            stringBuilder.AppendLine("Order items:");
            foreach (OrderItem item in Items)
                stringBuilder.AppendLine($"{item.Product.Name}, {item.Price}, Quantity: {item.Quantity}, Subtotal: {item.subTotal}");
            stringBuilder.AppendLine($"Total price: {total()}");
            return stringBuilder.ToString();
        }
    }
}
