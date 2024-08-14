using System;
using System.Globalization;
using _132_exercicio_proposto_enumeracoes_composicao.Entities;
using _132_exercicio_proposto_enumeracoes_composicao.Entities.Enums;

namespace _132_exercicio_proposto_enumeracoes_composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                
                order.AddItem(orderItem);
                
                Console.WriteLine();
            }

            Console.WriteLine($"ORDER SUMMARY \n{order}");
        }
    }
}