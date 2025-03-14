namespace Part2.OOP.ConstructorChainWithMuhammadqodir
{
    public class ConstructorChain : ParentClass
    {
        public ConstructorChain() : this("Muhammadqodir", 22)
        {
            Console.WriteLine("bu birinchi ctor");
        }
        public ConstructorChain(string name, int age) : base()
        {
            Console.WriteLine("Bu ikkinchi cons");
        }
    }

    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Bu ota class!");
        }
    }
}
