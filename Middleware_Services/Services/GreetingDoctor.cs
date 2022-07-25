namespace Middleware_Services.Services
{
    public class GreetingDoctor : Greetings
    {
        public GreetingDoctor(ILogger<GreetingDoctor> logger, IHostApplicationLifetime lifetime, IWebHostEnvironment webHost)
        {
            _logger = logger;
            _lifetime = lifetime;
            _webHost = webHost;
        }
        private readonly ILogger _logger;
        private readonly IHostApplicationLifetime _lifetime;
        private readonly IWebHostEnvironment _webHost;

        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Bye Doc!");
            _logger.LogInformation("I just greeted a doctor");
            _logger.LogInformation("We're using a {0}",nameof(_lifetime));
            _logger.LogInformation("We're hosted in {0} mode",_webHost.EnvironmentName);
        }
    }
}
