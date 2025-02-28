namespace Part5
{
    public class AsyncAwait
    {
        public static async Task CookDinnerAsync()
        {
            Console.WriteLine("Cooking has been started....");
            await Task.Delay(5000);
            Console.WriteLine("Adding pasta....");
        }
    }
}
