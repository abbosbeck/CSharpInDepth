namespace Part2.Types
{
    public class UsingRecords
    {
        public static void Main()
        {
            var person1 = new Person(name: "Abbos", 21);
            var person2 = new Person("Abbos", 21);

            var newPerson = person1 with { name = "New Name" };

            Console.WriteLine(newPerson.name);
            Console.WriteLine(person1.name);
        }

        public record Person(string name, int age);
    }
}
