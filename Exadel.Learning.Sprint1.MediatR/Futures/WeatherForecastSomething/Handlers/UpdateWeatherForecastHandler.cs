using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands;
using MediatR;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Handlers
{
    public class UpdateWeatherForecastHandler : IRequestHandler<UpdateWeatherForecastCommand, WeatherForecast>
    {
        private readonly List<WeatherForecast> _forcasts = new();
        public Task<WeatherForecast> Handle(UpdateWeatherForecastCommand request, CancellationToken cancellationToken)
        {
            var forecast = _forcasts.FirstOrDefault(f => f.Id == request.Id);
            if (forecast == null)
                throw new Exception("There is no data with this id.");

            forecast.Date = request.Date;
            forecast.TemperatureC = request.TemperatureC;
            forecast.Summary = request.Summary;

            return Task.FromResult(forecast);
        }
    }
}
