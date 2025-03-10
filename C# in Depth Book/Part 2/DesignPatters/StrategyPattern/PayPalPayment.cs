namespace Part2.DesignPatters.StrategyPattern
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(int amount) =>
            Console.WriteLine($"📧 Paid {amount} using PayPal.");
    }
}
