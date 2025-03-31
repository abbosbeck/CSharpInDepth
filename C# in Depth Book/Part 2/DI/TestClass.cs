namespace Part2.DI
{
    public class TestClass(string name)
    {
        private int Age;
        public TestClass(int age) : this("Abbos")
        {
            Age = age;
        }
        public void PrintName()
        {
            Console.WriteLine(Age);
        }
    }
}
