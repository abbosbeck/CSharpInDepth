using MediatR;
using Microsoft.VisualBasic;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands
{
    public record CreateWeatherForecastCommand(DateOnly Date, int TemperatureC, string summary) : IRequest<WeatherForecast>;
}
