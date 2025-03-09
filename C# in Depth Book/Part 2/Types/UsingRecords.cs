namespace Part2.Types
{
    public class UsingRecords
    {
        public static void Main()
        {
            var person1 = (Name: "Abbos", Age: 21);
            var person2 = (Name: "Abbos", Age: 21);

            Console.WriteLine(person1 == person2);
        }
    }
}
