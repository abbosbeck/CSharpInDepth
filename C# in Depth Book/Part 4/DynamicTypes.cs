namespace Part4
{
    public class DynamicTypes
    {
        public static void Run()
        {
            dynamic text = "Hello, World!";
            string world = text.Substring(6);
            Console.WriteLine(world);

            string broken = text.SUBSTR(6);
            Console.WriteLine(broken);

        }
    }
}
