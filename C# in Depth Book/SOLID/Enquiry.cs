namespace SOLID
{
    public class Enquiry : Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales) - 5;
        }

        public override void Add()
        {
            throw new Exception("Not allowed!");

            // this is not a good idea, because we are focing the class Enquiry to implement redundant methods. 
            // SOLID - Liskov Subsitution Principle - works here.
            // This means they do not what their parents do.
            // Don't force classes to implement unnecessary methods. Istead, create small Interface 
        }
    }

    public class EnquiryLSP : IDiscount
    {
        public double GetDiscount(double TotalSales)
        {
            return TotalSales - 5; 

            // this is good idea. Enquiry, indeed, was not a child of Customer. 
        }
    }
}
