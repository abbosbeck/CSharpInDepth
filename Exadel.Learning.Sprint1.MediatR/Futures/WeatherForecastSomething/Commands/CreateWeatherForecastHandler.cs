using MediatR;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands
{
    public class CreateWeatherForecastHandler : IRequestHandler<CreateWeatherForecastCommand, WeatherForecast>
    {
        private static readonly List<WeatherForecast> _forecasts = new(); 
        public async Task<WeatherForecast> Handle(CreateWeatherForecastCommand request, CancellationToken cancellationToken)
        {
            var newForcast = new WeatherForecast
            {
                Id = _forecasts.Count + 1,
                Date = request.Date,
                TemperatureC = request.TemperatureC
            };

            _forecasts.Add(newForcast);
            return await Task.FromResult(newForcast);
        }
    }
}
