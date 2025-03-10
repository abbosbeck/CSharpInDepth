namespace Part2.DesignPatters.StrategyPattern
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(int amount) =>
            Console.WriteLine($"💳 Paid {amount} using Credit Card.");
    }
}
