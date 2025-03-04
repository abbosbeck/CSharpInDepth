namespace SOLID
{
    class SilverCustomer : Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales) - 10;
        }
    }
}
