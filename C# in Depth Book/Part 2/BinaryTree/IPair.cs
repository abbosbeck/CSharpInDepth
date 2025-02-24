namespace Part2.BinaryTree
{
    public interface IPair<T>
    {
        T First { get; }
        T Second { get; }
        IEnumerator<T> GetEnumerator();
    }
}
