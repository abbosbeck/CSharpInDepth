namespace Part2.OOP
{
    public interface ITwo
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("This is ITwo Interface. Result: ", a * b);
        }
    }
}
