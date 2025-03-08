using static Part2.OOP.AccessModifiers;

namespace Part2.OOP
{
    public class AccessModifiers
    {
        protected internal class FromSameAssembly
        {

        }
    }
}

namespace Part2.OOP.test
{
    internal class Testing : FromSameAssembly
    {

    }
}
