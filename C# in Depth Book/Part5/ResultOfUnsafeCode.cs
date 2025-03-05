namespace Part5
{
    public class ResultOfUnsafeCode
    {
        public static async Task DelayWithResultOfUnsafeCode(string text)
        {
            int total = 0;
            unsafe
            {
                fixed (char* textPointer = text)
                {
                    char* p = textPointer;
                    while (*p != 0)
                    {
                        total += *p;
                        p++;
                    }
                }
            }
            Console.WriteLine("Delaying for " + total + "ms");
            await Task.Delay(total);
            Console.WriteLine("Delay completed");
        }
    }
}
