using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands;
using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Queries;
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

        [HttpPost]
        public async Task<IActionResult> CreateForecastAsync(CreateWeatherForecastCommand command)
        {
            var result = await _sender.Send(command);
            
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWeatherForcast(UpdateWeatherForecastCommand command)
        {
            var result = await _sender.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteForecastAsync(DeleteWeatherForecastCommand command)
        {
            var result = await _sender.Send(command);

            return Ok(result);
        }
    }
}
