using Enumerações.Entities.Enums;

namespace Enumerações.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Date}, {Status}";
        }
    }
}