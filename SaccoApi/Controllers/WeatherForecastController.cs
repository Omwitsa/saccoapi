using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaccoApi.Models;
using System.Text.Json.Serialization;

namespace SaccoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : Controller
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public JsonResult Get()
        {
            return Json("Amtech Api Working");
        }
    }
}