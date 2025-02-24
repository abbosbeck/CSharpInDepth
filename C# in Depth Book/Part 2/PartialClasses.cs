using System.Collections;

namespace Part2
{
    class PartialClasses
    {

    }

    public partial class MyClass
    {
        public partial int ComputeValue();  // No implementation yet
    }

    public partial class MyClass
    {
        public partial int ComputeValue()  // Implemented here
        {
            return 42;
        }
    }

    public class CsharpBuildInTypes : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "int";
            yield return "double";
            yield return "string";
            yield return "bool";
            yield return "obj";
            yield return "decimal";
            yield return "char";
            yield return "byte";
                
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
