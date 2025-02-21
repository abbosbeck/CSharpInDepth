namespace Part2
{
    class PartialClasses
    {

    }

    public partial class MyClass
    {
        public partial int ComputeValue();  // No implementation yet
    }

    public partial class MyClass
    {
        public partial int ComputeValue()  // Implemented here
        {
            return 42;
        }
    }

}
