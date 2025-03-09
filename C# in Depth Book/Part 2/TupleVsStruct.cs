namespace Part2
{
    public class TupleVsStruct
    {
        public static void Main()
        {
            var person = (Name: "Abbos", Age: 21, isStudent: true);

            Console.WriteLine(person.isStudent);
        }
    }
}
