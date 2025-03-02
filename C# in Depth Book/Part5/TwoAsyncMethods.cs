namespace Part5
{
    class TwoAsyncMethods
    {
        public static async Task FirstTask()
        {
            Console.WriteLine("Firs task has been started");
            await Task.Delay(5000);
            Console.WriteLine("First task has been finished....");
        }

        public static async Task SecondTask()
        {
            Console.WriteLine("Second task has been started");
            await Task.Delay(3000);
            Console.WriteLine("Second task has been finished....");
        }
    }
}
