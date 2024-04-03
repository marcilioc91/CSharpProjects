using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            order.Client.Name = Console.ReadLine();

            Console.Write("Email: ");
            order.Client.Email = Console.ReadLine();

            Console.Write("Birth date: ");
            order.Client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            order.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine().ToUpper());

            Console.WriteLine("*****************************************************");
            Console.Write("How many items to this order? ");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("*****************************************************");

            for (int i = 1; i <= n; i++)
            {
                Product product = new Product();
                Console.WriteLine($"Enter #{i} data:");
                Console.Write("Product name: ");
                product.Name = Console.ReadLine();

                Console.Write("Product price: ");
                product.Price = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, product.Price, product);

                order.Moment = DateTime.Now;
                order.AddItem(orderItem);
                Console.WriteLine();
            }

            Console.WriteLine("*****************************************************");
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
