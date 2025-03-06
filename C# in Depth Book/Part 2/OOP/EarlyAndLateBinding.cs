namespace Part2.OOP
{
    class EarlyAndLateBinding
    {
    }

    public class Person
    {
        public virtual void Speak()
        {
            Console.WriteLine("Person is speaking");
        }
    }

    public class Student : Person
    {
        public override void Speak()
        {
            Console.WriteLine("Student is speaking");
        }
    }
}
