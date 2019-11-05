using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;

namespace IdentityAngular.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserOrderController : ControllerBase
    {
        private static readonly string[] Titles = new[]
        {
            "Table",
            "Chair",
            "Mirror",
            "Desk",
            "TV",
            "Radio",
            "PC",
            "Smartphone",
            "Shoes",
            "Hat",
            "Tickets"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public UserOrderController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<UserOrder> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new UserOrder
            {
                DateOfPurchase = DateTime.Now.AddDays(index*-1),
                Title = Titles[rng.Next(Titles.Length)],
                TotlalAmount = rng.Next(1, 999) + ((rng.Next(0, 99))*0.01),
                Status = (rng.Next(0,1)%2 == 0)
            })
            .ToArray();
        }
    }
}
