using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Queries;
using MediatR;

namespace Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Handlers
{
    public class GetWeatherForecastHandler : IRequestHandler<WeatherForecastQuery, IEnumerable<WeatherForecast>>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public Task<IEnumerable<WeatherForecast>> Handle(WeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var forecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = "Something",
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });


            return Task.FromResult(forecast);
        }
    }
}
