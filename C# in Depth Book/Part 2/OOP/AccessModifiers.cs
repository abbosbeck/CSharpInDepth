using static Part2.OOP.AccessModifiers;

namespace Part2.OOP
{
    public class AccessModifiers
    {
        public class FromSameAssembly
        {

        }
    }

    public class B : AccessModifiers
    {
        static B()
        {
            
        }

        static int a = 15;
    }
}

