namespace Part2.OOP
{
    public class Animal
    {
        protected internal virtual void Speak()
        {
            Console.WriteLine("Animal speaks...");
        }

        protected internal virtual void Speak2() { }
    }

    public class Cat : Animal
    {
        protected internal override void Speak()
        {
            base.Speak();
            Console.WriteLine("Meow!");
        }
    }
}
