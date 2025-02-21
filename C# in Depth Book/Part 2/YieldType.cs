namespace Part2
{
    class YieldType
    {
        public IEnumerable<int> Numbers()
        {
            yield return SumNumber(5, 10);
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
            yield return 11;
            yield return 12;
            yield return 13;
            yield return 14;
        }

        public int SumNumber(int a, int b)
            => a + b;

    }
}
