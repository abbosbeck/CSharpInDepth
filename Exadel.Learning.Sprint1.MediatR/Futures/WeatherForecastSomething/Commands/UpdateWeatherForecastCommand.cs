using MediatR;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands
{
    public record UpdateWeatherForecastCommand(int Id, string Date, int TemperatureC, string Summary) : IRequest<WeatherForecast?>;
}
