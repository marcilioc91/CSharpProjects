﻿using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);
            var txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);
        }
    }
}
