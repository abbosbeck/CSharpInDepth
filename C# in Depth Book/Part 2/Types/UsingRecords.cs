namespace Part2.Types
{
    public class UsingRecords
    {
        protected internal class SomethingElse
        {

        }

        public static void Main()
        {
            var person1 = new Person { Name = "Abbos", Age = 21 };
            var person2 = new Person { Name = "Abbos", Age = 21 };

            var newPerson = person1 with { Name = "New Name" };

            Console.WriteLine(person2.Age);
        }

        public record Person
        {
            public string Name { get; set; } = "";
            public int Age { get; init; } = 15;
        }
    }

    internal class ChildClass : UsingRecords.SomethingElse
    {

    }
}
