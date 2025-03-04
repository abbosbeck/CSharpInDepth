namespace Part5
{
    class TwoAsyncMethods
    {
        public static async Task FirstTask()
        {
            Console.WriteLine("Firs task has been started");
            await Task.Delay(2/8);
            Console.WriteLine("First task has been finished....");
        }

        public static async Task SecondTask()
        {
            Console.WriteLine("Second task has been started");
            await Task.Delay(3000);
            Console.WriteLine("Second task has been finished....");
        }

        public static int WithoutAsync()
        {
            return 15;
        }
    }

    public class BreakFastTask
    {
        public static async Task Caller()
        {
            var breakfastTasks = new List<Task> { eggsTask(), baconTask(), toastTask() };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask())
                {
                    Console.WriteLine("Eggs are ready");
                }
                else if (finishedTask == baconTask())
                {
                    Console.WriteLine("Bacon is ready");
                }
                else if (finishedTask == toastTask())
                {
                    Console.WriteLine("Toast is ready");
                }
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }
        }

        private static async Task eggsTask()
        {
            Console.WriteLine("Cooking eggs method....");
            await Task.Delay(3000);
            Console.WriteLine("Eggs are ready method");
        }

        public static async Task baconTask()
        {
            Console.WriteLine("Cooking bacon method....");
            await Task.Delay(5000);
            Console.WriteLine("Bacon is ready method");
        }
        public static async Task toastTask()
        {
            Console.WriteLine("Cooking toast method....");
            await Task.Delay(2000);
            Console.WriteLine("Toast is ready method");
        }
    }
}
