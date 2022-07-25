using Microsoft.AspNetCore.Mvc;
using Middleware_Services.Services;

namespace Middleware_Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(Greetings greeting)
        {
            //_messageService = messageService ?? throw new ArgumentException(nameof(messageService));
            _greetings = greeting;
        }

        //private readonly IMessagingService _messageService;
        private readonly Greetings _greetings;

        //[HttpPost]
        //public ActionResult SendMessage()
        //{
        //    _messageService.SendMessage("Hello!");
        //    return Ok();
        //}

        [HttpPost]
        public ActionResult Greet()
        {
            _greetings.Greet();
            return Ok();
        }
    }
}