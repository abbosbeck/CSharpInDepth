namespace Part5
{
    public class AwaitingCompletedAndNonCompletedTasks
    {
        public static async Task DemoCompleteAsync()
        {
            Console.WriteLine("Before firs await");
            await Task.FromResult(10);
            Console.WriteLine("Between awaits");
            await Task.Delay(1000);
            Console.WriteLine("After second await");
        }
    }
}
