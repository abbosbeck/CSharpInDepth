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

        public void Show() => Console.WriteLine("This is a message from the Base Class..");

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

        public void Show(string text) => Console.WriteLine("This message is from the Child class");
    }
}
