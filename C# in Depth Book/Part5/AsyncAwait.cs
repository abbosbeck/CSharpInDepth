namespace Part5
{
    public class AsyncAwait
    {
        public static async Task CookDinnerAsync()
        {
            Console.WriteLine("Cooking has been started....");
            Task.Delay(5000).Wait();
            Console.WriteLine("Adding pasta....");
        }

        public static async Task<int> Main()
        {
            Task.Delay(5000);
            Console.WriteLine("Hello World! This is from AsyncAwait.cs. I think, this message shouldn't be displayed on the Console. ");
            return 42;
        }
    }
}
