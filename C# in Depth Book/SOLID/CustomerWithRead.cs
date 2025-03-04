namespace SOLID
{
    class CustomerWithRead : IDatabaseV1
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            // some logic here
            // whoever needs Read method calls IDatabaseV1 method. This means Interface segragation principle
        }
    }
}
