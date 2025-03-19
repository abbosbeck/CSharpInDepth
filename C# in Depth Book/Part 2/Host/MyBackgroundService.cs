using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Part2.Host
{
    public class MyBackgroundService : BackgroundService
    {
        private readonly ILogger<MyBackgroundService> _logger;
        public MyBackgroundService(ILogger<MyBackgroundService> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Running background task");

                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}
