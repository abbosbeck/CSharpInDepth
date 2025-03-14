namespace Part2.OOP
{
    public class InterfaceCaller : IOne, ITwo
    {
        public void Aaaaa()
        {
            Console.WriteLine("What is going on..");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine("This message is from Class...");
        }
    }
}
