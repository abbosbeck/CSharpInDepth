using MediatR;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands
{
    public record DeleteWeatherForecastCommand(int id) : IRequest<bool>;
}
