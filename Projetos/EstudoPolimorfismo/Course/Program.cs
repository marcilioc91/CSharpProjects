using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number od products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch  != 'c' && ch != 'u' && ch != 'i')
                {
                    Console.WriteLine("Error! Try again.\n---------------------------------");
                    i--;
                    continue;
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'u')
                {
                    Console.Write("Manufacture date: ");
                    DateTime manufactureData = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(manufactureData, name, price));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(customFee, name, price));
                }
                else
                    products.Add(new Product(name, price));
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (var produto in products)
                Console.WriteLine(produto.PriceTag());
        }
    }
}
