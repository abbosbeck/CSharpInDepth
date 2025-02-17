namespace Part2
{
    public class AnonymousTypesAndAnonymousTypesAndTuples
    {
        public void TupleTypes()
        {
            var book = (title: "C# in Depth", author: "Jon Skeet", age: 15);

            book.title= "Hello world";

            Console.WriteLine(book.title);
        }

        public void AnonymousType()
        {
            var book = new { Title = "C# in Depth", Author = "Jon Skeet", Age = 15};


            Console.WriteLine(book.Title);
        }
    }
}
