using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (var item in OrderItems)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Order moment {Moment:dd/MM/yyyy HH:mm:ss}");
            stringBuilder.AppendLine($"Order status: {Status}");
            stringBuilder.AppendLine($"Client: {Client}");
            stringBuilder.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
            {
                stringBuilder.AppendLine($"{item}");
            }
            stringBuilder.AppendLine($"Total price: {Total():c}");
            return stringBuilder.ToString();
        }
    }
}
