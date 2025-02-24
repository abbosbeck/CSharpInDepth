using System.Collections;

namespace Part2.BinaryTree
{
    public struct Pair<T> : IPair<T>, IEnumerable<T>
    {
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public T First { get;  }

        public T Second { get; }

        public IEnumerator<T> GetEnumerator()
        {
            yield return First;
            yield return Second;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class BinaryTree<T> : IEnumerable<T>
    {
        public BinaryTree(T value)
        {
            Value = value;
        }

        T Value { get; }
        public Pair<BinaryTree<T>> SubItems;

        public IEnumerator<T> GetEnumerator()
        {
            yield return Value;

            foreach(BinaryTree<T> tree in SubItems)
            {
                if(tree != null)
                {
                    foreach(T item in tree)
                    {
                        yield return item;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
