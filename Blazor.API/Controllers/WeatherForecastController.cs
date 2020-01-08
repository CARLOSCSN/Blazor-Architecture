using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Newtonsoft.Json;
using System.Diagnostics;
using Blazor.Domain.Supervisor;
using Blazor.Domain.ApiModels;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;

namespace Blazor.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class WeatherForecastController : Controller
    {
        private readonly IBlazorSupervisor _BlazorSupervisor;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IBlazorSupervisor BlazorSupervisor, ILogger<WeatherForecastController> logger)
        {
            _BlazorSupervisor = BlazorSupervisor;
            _logger = logger;
        }

        [HttpGet]
        [Produces(typeof(List<WeatherForecastApiModel>))]
        public async Task<ActionResult<IEnumerable<WeatherForecastApiModel>>> Get(CancellationToken ct = default)
        {
            try
            {
                return new ObjectResult(await _BlazorSupervisor.GetAllWeatherForecastAsync(ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(WeatherForecastApiModel))]
        public async Task<ActionResult<WeatherForecastApiModel>> Get(int id, CancellationToken ct = default)
        {
            try
            {
                var album = await _BlazorSupervisor.GetWeatherForecastByIdAsync(id, ct);
                if (album == null)
                {
                    return NotFound();
                }

                return Ok(album);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<WeatherForecastApiModel>> Post([FromBody] WeatherForecastApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, await _BlazorSupervisor.AddWeatherForecastAsync(input, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<WeatherForecastApiModel>> Put(int id, [FromBody] WeatherForecastApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await _BlazorSupervisor.GetAlbumByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                var errors = JsonConvert.SerializeObject(ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage));
                Debug.WriteLine(errors);

                if (await _BlazorSupervisor.UpdateWeatherForecastAsync(input, ct))
                {
                    return Ok(input);
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id, CancellationToken ct = default)
        {
            try
            {
                if (await _BlazorSupervisor.GetWeatherForecastByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                if (await _BlazorSupervisor.DeleteWeatherForecastAsync(id, ct))
                {
                    return Ok();
                }

                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}