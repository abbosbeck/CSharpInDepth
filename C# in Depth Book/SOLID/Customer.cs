namespace C__in_Depth_Book.SOLID
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
    }

    class FileLogger
    {
        public void Handle (Exception ex) 
        {
            File.WriteAllText(@"C:\Error.txt", ex.Message); 
        }
    }
}
