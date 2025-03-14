namespace Part2.Exadel.Interview
{
    public class CarService
    {
        public async Task ChargeAllCarsAsync(List<ElectricCar> cars)
        {
            foreach (var car in cars)
            {
                await car.ChargeAsync();
            }
        }
    }
}
