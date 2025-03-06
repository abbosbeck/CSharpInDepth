namespace Part2.DesignPatters
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

            // IUnitOfWork.Products = new ProductRepository(_appDbContext);
            // IUnitOfWork.Orders = new OrderRepository(_appDbContext);
        }
        IProductRepository IUnitOfWork.Products => throw new NotImplementedException();

        IOrderRepository IUnitOfWork.Orders => throw new NotImplementedException();

        public void Commit()
        {
            // _context.SaveChanges();
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            // _context.Dispose();
            throw new NotImplementedException();
        }
    }

    public class AppDbContext
    {
    }
}
