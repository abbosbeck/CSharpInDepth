namespace Part2
{
    abstract class Animal
    {
        public abstract void MakeSound();
        public void Eat() => Console.WriteLine("Eating...");
    }

    interface IFlyable
    {
        void Fly();
    }

    class Bird : Animal, IFlyable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Chirp Chirp!");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying...");
        }
    }

}
