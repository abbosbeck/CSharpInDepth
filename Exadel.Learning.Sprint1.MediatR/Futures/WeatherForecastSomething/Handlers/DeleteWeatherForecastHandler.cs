using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands;
using MediatR;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Handlers
{
    public class DeleteWeatherForecastHandler : IRequestHandler<DeleteWeatherForecastCommand, bool>
    {
        private readonly List<WeatherForecast> _forecast = new();
        public Task<bool> Handle(DeleteWeatherForecastCommand request, CancellationToken cancellationToken)
        {
            var forecast = _forecast.Find(f => f.Id == request.id);
            if (forecast == null)
            {
                return Task.FromResult(false);
                throw new Exception("There is no data with this id.");
            }

            _forecast.Remove(forecast);

            return Task.FromResult(true);
        }
    }
}
