namespace Part2
{
    unsafe struct VersionedData
    {
        public int Major;
        public int Minor;
        public fixed int Data[16];
    }
}
