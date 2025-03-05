namespace SOLID
{
    internal interface IDatabase
    {
        void Add();
        // void Read(); if only some "users" need this class,
        // it is not a good idea to write it here.
        // Instead, writing it in segragated interface would be much better
        // This means Interface Segragation Principle (ISP)
    }
}