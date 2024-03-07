using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> orderItems { get; set; }
        //public Client Client { get; set; }

        public Order()
        {
        }

        //public Order(DateTime moment, OrderStatus status, List<OrderItem> orderItems, Client client)
        //{
        //    Moment = moment;
        //    Status = status;
        //    this.orderItems = orderItems;
        //    Client = client;
        //}
    }
}
