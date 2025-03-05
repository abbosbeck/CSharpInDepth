namespace Part2.OOP
{
    public class Animal
    {
        public Animal(string text)
        {
            Console.WriteLine($"This message ``{text}`` came from child class");
        }
        protected internal virtual void Speak()
        {
            Console.WriteLine("Animal speaks...");
        }

        protected internal virtual void Speak2() { }
    }

    public class Cat : Animal
    {
        public Cat() : base("Hiiii")
        {
            
        }
        protected internal override void Speak()
        {
            base.Speak();
            Console.WriteLine("Meow!");
        }
    }
}
