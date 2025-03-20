namespace Part2.Exadel.Interview
{
    public class ElectricCar
    {
        public async Task ChargeAsync()
        {
            await Task.Delay(TimeSpan.FromMinutes(5));
        }
    }
}
