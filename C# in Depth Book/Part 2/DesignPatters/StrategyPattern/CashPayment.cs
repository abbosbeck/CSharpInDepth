namespace Part2.DesignPatters.StrategyPattern
{
    public class CashPayment : IPaymentStrategy
    {
        public void Pay(int amount) =>
            Console.WriteLine($"Paid {amount} using Cash.");
    }
}
