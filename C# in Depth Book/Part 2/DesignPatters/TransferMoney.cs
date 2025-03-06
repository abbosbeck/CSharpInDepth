namespace Part2.DesignPatters
{
    class TransferMoney
    {
        public void TransferMoneyAsync(int fromAccount, int toAccount, int amount)
        {
            var sender = new UnitOfWork(new AppDbContext());
            // sender.Balance -= amount;

            var receiver = new UnitOfWork(new AppDbContext());
            // receiver.Balance += amount;

            // UnitOfWork.Commit(); We have to save data here, this is why we do not lose "amount" halfway-trough
        }
    }
}
