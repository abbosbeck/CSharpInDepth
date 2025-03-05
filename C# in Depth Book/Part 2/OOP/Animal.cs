namespace Part2.OOP
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks...");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
}
