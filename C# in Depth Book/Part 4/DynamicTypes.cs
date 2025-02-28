namespace Part4
{
    public class DynamicTypes
    {
        public static object StaticValue = "string";
        public static void Run(dynamic d)
        {
            /*dynamic text = "Hello, World!";
            string world = text.Substring(6);
            Console.WriteLine(world);

            string broken = text.SUBSTR(6);
            Console.WriteLine(broken);*/

            SampleMethod(d);
        }

        public static void NeverCalledMethod()
        {
            dynamic a = "anjkngje";

            int b = (int)a;
        }

        public static void SampleMethod(int a)
        {
            Console.WriteLine("This is Sample method came from int a");
        }

        public static void SampleMethod(string a)
        {
            Console.WriteLine("String works here");
        }
        public static void SampleMethod(bool a)
        {
            Console.WriteLine("This is bool type");
        }

        public static void SampleMethod(dynamic a)
        {
            Console.WriteLine("this is a dynamic typed method");
        }
    }

    public class DifferenceBetweenDynamicTypesAndObject
    {
        public static void Main()
        {
            object a = "string";
            object b = 15;
            object c = TimeSpan.FromMinutes(45);
            string aString = (string)a;
            string bString = (string)b;

            dynamic dynamicA = "string";
            int dynamicB = dynamicA;
        }
    }
}
