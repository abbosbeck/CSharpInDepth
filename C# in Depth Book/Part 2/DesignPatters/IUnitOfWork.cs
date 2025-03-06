namespace Part2.DesignPatters
{
    interface IUnitOfWork
    {
        IProductRepository Products { get; }
        IOrderRepository Orders { get; }
        void Commit();
        void Rollback();
    }

    internal interface IOrderRepository
    {
    }

    internal interface IProductRepository
    {
    }
}
