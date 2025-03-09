namespace Part2.Types
{
    public class UsingRecords
    {
        public static void Main()
        {
            var person1 = new Person(name: "Abbos", 21);
            var person2 = new Person("Abbos", 21);

            person1 = person1 with { name = "New Name" };

            Console.WriteLine(person1 == person2);
        }

        public record Person(string name, int age);
    }
}
