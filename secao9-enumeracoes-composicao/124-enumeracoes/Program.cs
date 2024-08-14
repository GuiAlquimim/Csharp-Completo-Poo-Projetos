using _124_enumeracoes.Entities;
using _124_enumeracoes.Entities.Enums;

namespace _124_enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 112,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string text = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(text);

            OrderStatus ab = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(ab);
        }
    }
}