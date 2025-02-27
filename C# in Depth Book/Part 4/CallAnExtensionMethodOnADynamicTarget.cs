namespace Part4
{
    public class CallAnExtensionMethodOnADynamicTarget
    {
        public static bool Run()
        {
            dynamic source = new List<dynamic>
            {
                5,
                7.5,
                "M",
                TimeSpan.FromSeconds(75)
            };

            //return source.Any();

            return Enumerable.Any(source);
        }
    }
}
