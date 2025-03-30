using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Commands;
using Exadel.Learning.Sprint1.MediatR.Futures.WeatherForecastSomething.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Exadel.Learning.Sprint1.MediatR.Controllers
{
    public class WeatherForecastController(ISender mediator) : ApiControllerBase(mediator)
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await mediator.Send(new WeatherForecastQuery());
        }

        [HttpPost]
        public async Task<IActionResult> CreateForecastAsync(CreateWeatherForecastCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWeatherForcast(UpdateWeatherForecastCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteForecastAsync(DeleteWeatherForecastCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
