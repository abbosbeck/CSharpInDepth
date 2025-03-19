using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Part2.Host
{
    public class RefershingAPITokensBackgroundService : BackgroundService
    {
        private readonly ILogger<TokenRefreshService> _logger;
        public RefershingAPITokensBackgroundService(ILogger<TokenRefreshService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Refreshing API tokens...");
                await Task.Delay(TimeSpan.FromMinutes(15), stoppingToken);
            }
        }
    }

    public class TokenRefreshService
    {
    }
}
