using System.Globalization;

namespace Course.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        CultureInfo usCulture = new CultureInfo("en-US");

        public virtual string PriceTag()
        {
            return $"{Name} {Price.ToString("C", usCulture)}";
        }
    }
}
