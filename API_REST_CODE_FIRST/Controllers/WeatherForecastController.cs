using API_REST_CODE_FIRST.Contexts;
using API_REST_CODE_FIRST.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_REST_CODE_FIRST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private ContextoBD contextoBD;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ContextoBD contextoBD)
        {
            _logger = logger;
            this.contextoBD = contextoBD;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            Professor p = new Professor()
            {
                Nome = "Melo",
                Titulacao = "Mestre",
                Cpf = "123"
            };
            contextoBD.Professores.Add(p);
            Disciplina d = new Disciplina()
            {
                Nome = "CSHARP",
                Descricao = "Curso CSHARP"
            };
            contextoBD.Disciplinas.Add(d);
            contextoBD.SaveChanges();
            
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}