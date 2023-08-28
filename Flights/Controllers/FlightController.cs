using Flights.ReadModels;
using Microsoft.AspNetCore.Mvc;

namespace Flights.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        Random random = new Random();

        private readonly ILogger<FlightController> _logger;
        
        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FlightRm> Search()      
            => new FlightRm[]
               {
                   new (
                       Guid.NewGuid(),
                       "Buzz",
                       random.Next(90,5000),
                       new TimePlaceRm("Istanbul", DateTime.Now.AddHours(random.Next(1,3))),
                       new TimePlaceRm("Gdańsk", DateTime.Now.AddHours(random.Next(5,8))),
                       random.Next(1,10)
                       ),
                    new (
                       Guid.NewGuid(),
                       "Ryanair",
                       random.Next(90,5000),
                       new TimePlaceRm("Wrocław", DateTime.Now.AddHours(random.Next(10,12))),
                       new TimePlaceRm("Lisbon", DateTime.Now.AddHours(random.Next(16,20))),
                       random.Next(1,10)
                       ),
                    new (
                       Guid.NewGuid(),
                       "Wizzair",
                       random.Next(90,5000),
                       new TimePlaceRm("London", DateTime.Now.AddHours(random.Next(18,22))),
                       new TimePlaceRm("Paris", DateTime.Now.AddHours(random.Next(25,27))),
                       random.Next(1,10)
                       ),
                    new (
                       Guid.NewGuid(),
                       "Lufthansa",
                       random.Next(90,5000),
                       new TimePlaceRm("Berlin", DateTime.Now.AddHours(random.Next(29,31))),
                       new TimePlaceRm("Oslo", DateTime.Now.AddHours(random.Next(35,37))),
                       random.Next(1,10)
                       ),


               };
        
    }
}