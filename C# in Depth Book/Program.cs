using Part2;

/* Types  var anonymousTypesAndTuples = new AnonymousTypesAndAnonymousTypesAndTuples();

anonymousTypesAndTuples.TupleTypes();

anonymousTypesAndTuples.AnonymousType();

await anonymousTypesAndTuples.GetWeatherAsync();
anonymousTypesAndTuples.GetEmailStatusAsync();

await Task.Delay(1001);

Console.WriteLine("Hello World! This is from Program.cs"); */

foreach(string name in Generics.GenerateNames())
{
    Console.WriteLine(name);
}
