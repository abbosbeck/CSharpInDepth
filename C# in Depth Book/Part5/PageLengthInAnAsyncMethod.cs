namespace Part5
{
    public class PageLengthInAnAsyncMethod
    {
        static readonly HttpClient client = new HttpClient();
        public static async Task<int> GetPageLength(string url)
        {
            /* Console.WriteLine("Fetching page length...");
             Task<string> fetchTextTask = client.GetStringAsync("http://www.microsoft.com");
             Console.WriteLine("Doing other work...");
             int length = (await fetchTextTask).Length;
             Console.WriteLine("Page length is " + length);
             return length;*/


            Task<string> fetchTextTask = client.GetStringAsync(url);
            int length = (await fetchTextTask).Length;
            await Task.Delay(5000);
            return length;
        }
    }
}
