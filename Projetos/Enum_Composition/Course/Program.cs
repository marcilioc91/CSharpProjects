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
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Birth date: ");
            var birthDate = Console.ReadLine();
            Console.Write("How many items to this order? ");

            Client client = new Client
            {
                Name = name,
                Email = email,
                BirthDate = DateTime.Parse(birthDate)
            };
            var n = int.Parse(Console.ReadLine());

        }
    }
}
