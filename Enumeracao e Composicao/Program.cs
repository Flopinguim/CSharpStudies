using Enumeracao_e_Composicao.Entities;
using Enumeracao_e_Composicao.Entities.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Enumeracao_e_Composicao
{
    public class Program
    {
        static void Main(string[] args)
        {
            string clientName = string.Empty;
            string email = string.Empty;
            DateTime birthDay = DateTime.Now;
            OrderStatus status;
            int numItens;
            string productName;
            double productPrice;
            int productQtde;
            Product product = new Product();
            OrderItem orderItem = new OrderItem();

            // Client
            Console.WriteLine("Enter cliente data:");
            Console.Write("Nome: ");
            clientName = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            birthDay = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName,email,birthDay);

            // Order
            Console.WriteLine("Enter order data:");
            Console.Write("Order status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            // OrderItem
            order.Items = new List<OrderItem>();
            Console.WriteLine("How many items to this order?");
            numItens = int.Parse(Console.ReadLine());
            for (int i = 0; i < numItens; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name:");
                productName = Console.ReadLine();
                Console.Write("Product price:");
                productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity:");
                productQtde = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                product = new Product(productName, productPrice);
                orderItem = new OrderItem(productQtde,product);
                order.addItem(orderItem);
            }

            //Saída
            Console.WriteLine(order.ToString());
        }
    }
}
