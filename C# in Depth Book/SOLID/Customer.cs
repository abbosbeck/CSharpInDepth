namespace SOLID
{
    // Single Responsiblity Principle (SRP)
    class Customer
    {
        private FileLogger logger = new FileLogger();
        public void Add()
        {
            try
            {
                // logic
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Error.txt", ex.Message); // This is a bad idiea,
                                                                // because it is violating Single Responility Principle
            }
        }

        public void Remove() 
        {
            try
            {
                // logic
            }
            catch (Exception ex)
            {

                logger.Handle(ex); // this is a good idea,
                                   // because it is calling another class.
                                   // Our main (customer) class doesn't have unnecessary responsibilites
            }
        }

        public int CustomerType { get; set; }
        public double CustomerDiscount(double TotalSales) 
        {
            if (CustomerType == 0)
                return TotalSales - 100;
            else
                return TotalSales - 10; 
            // this is not a good idea, it is violating Open/Closed Peinciple (OCP)
            // The method should be closed to any kind of modification and opened to extention
        }

        public virtual double GetDiscount(double TotalSales) 
        {
            return TotalSales;
        }
    }
}
