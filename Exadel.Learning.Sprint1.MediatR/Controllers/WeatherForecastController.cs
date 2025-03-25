using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exadel.Learning.Sprint1.MediatR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ISender _sender;
        public WeatherForecastController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _sender.Send(new WeatherForecastQuery());
        }
    }
}
