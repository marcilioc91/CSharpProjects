using System.Globalization;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(double customsFee, string name, double price)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        CultureInfo usCulture = new CultureInfo("en-US");
        public override string PriceTag()
        {
            return $"{Name} {TotalPrice().ToString("C", usCulture)} (Customs fee: {CustomsFee.ToString("C", usCulture)})";
        }

        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
