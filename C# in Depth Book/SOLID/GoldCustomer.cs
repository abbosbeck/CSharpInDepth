namespace SOLID
{
    class GoldCustomer : Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales) - 100;
        }
    }
}
