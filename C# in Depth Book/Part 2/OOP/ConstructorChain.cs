namespace Part2.OOP
{
    class ConstructorChain
    {
        public string Brand;
        public int Year;

        public ConstructorChain() : this("Unknown", 2020)
        {
            
        }
        public ConstructorChain(string brand) : this(brand, 2022)
        {
            
        }
        public ConstructorChain(string brand, int year)
        {
            Brand = brand;
            Year = year;

            Console.WriteLine("Two-paramerter constructor called");
        }
    }
}
