using System.Diagnostics;
using System.Text;

namespace C__in_Depth_Book.Part_2.PerformanceTests
{
    public class StringVsStringBuilder
    {
        public static double StringPerformance()
        {
            Stopwatch sw = Stopwatch.StartNew();
            string str = "";

            for(int i = 0; i < 10000; i++)
            {
                str += i.ToString();
            }
            sw.Stop();

            return sw.Elapsed.TotalMilliseconds;
        }

        public static double StringBuilderPerformance()
        {
            Stopwatch sw = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(i.ToString()); // Modifies the same object 😀
            }
            sw.Stop();

            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
