namespace Part2.OOP
{
    public class RefAndOut
    {
        public static void ModifyValue(ref int number)
        {
            number = 0;
        }

        public static void Divide(int a, int b, out int result)
        {
            int t = a / b;

            result = t * t;
        }
    }
}
