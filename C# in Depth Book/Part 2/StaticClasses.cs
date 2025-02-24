namespace Part2
{
    static class StaticClassDemo
    {
        public static void StaticMethod() { }
        // public void InstanceMethod() { } this ain't possible, tho
        public class RegularNestedClass
        {
            public void InstanceMethod() { }
        }
    }
}
