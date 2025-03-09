namespace Part2
{
    public class TupleVsStruct
    {
        public static void Main()
        {
            var person = ("Abbos", 21, true);

            Console.WriteLine(person.Item1);
        }
    }
}
