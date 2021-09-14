using BlazorSlider.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSlider.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "https://costarica21.com/Img/Beach-San-Josesito-GDEL-00.jpg",
            "https://baraka.es/wp-content/uploads/2019/01/destacada-paisaje-costa-rica.jpg",
            "https://i.pinimg.com/originals/48/54/df/4854dfc74b052e442e72884fae99517c.jpg",
            "https://conozcasucanton.com/wp-content/uploads/sites/11/2016/10/Isla-del-Coco.jpg",
            "https://costarica.org/wp-content/uploads/2017/02/Volcanoe.jpg"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
