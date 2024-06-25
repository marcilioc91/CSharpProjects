namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            const double PERCENT_ADDITIONAL = 1.1;
            return base.Payment() + PERCENT_ADDITIONAL * AdditionalCharge;
        }
    }
}
