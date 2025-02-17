using Part2;

var anonymousTypesAndTuples = new AnonymousTypesAndAnonymousTypesAndTuples();

/*anonymousTypesAndTuples.TupleTypes();

anonymousTypesAndTuples.AnonymousType();*/

await anonymousTypesAndTuples.GetWeatherAsync();
anonymousTypesAndTuples.GetEmailStatusAsync();

await Task.Delay(1001);

Console.WriteLine("Hello World! This is from Program.cs");