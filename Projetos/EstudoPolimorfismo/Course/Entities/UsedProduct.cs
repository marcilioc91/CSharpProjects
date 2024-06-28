using System;
using System.Globalization;

namespace Course.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(DateTime manufactureDate, string name, double price)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        CultureInfo usCulture = new CultureInfo("en-US");
        public override string PriceTag()
        {
            return $"{Name} (Used) {Price.ToString("C", usCulture)} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";

        }
    }
}
