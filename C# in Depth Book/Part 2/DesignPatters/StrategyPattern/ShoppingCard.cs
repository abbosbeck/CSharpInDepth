namespace Part2.DesignPatters.StrategyPattern
{
    public class ShoppingCard
    {
        private IPaymentStrategy _paymentStrategy;
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout(int amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("❌ No payment method selected!");
                return;
            }
            _paymentStrategy.Pay(amount);
        }
    }
}
