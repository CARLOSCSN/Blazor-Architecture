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

namespace Blazor.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    [ResponseCache(Duration = 604800)]
    public class GenreController : Controller
    {
        private readonly IBlazorSupervisor _BlazorSupervisor;

        public GenreController(IBlazorSupervisor BlazorSupervisor)
        {
            _BlazorSupervisor = BlazorSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<GenreApiModel>))]
        public async Task<ActionResult<List<GenreApiModel>>> Get(CancellationToken ct = default)
        {
            try
            {
                return new ObjectResult(await _BlazorSupervisor.GetAllGenreAsync(ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(GenreApiModel))]
        public async Task<ActionResult<GenreApiModel>> Get(int id, CancellationToken ct = default)
        {
            try
            {
                var genre = await _BlazorSupervisor.GetGenreByIdAsync(id, ct);
                if ( genre == null)
                {
                    return NotFound();
                }

                return Ok(genre);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<GenreApiModel>> Post([FromBody] GenreApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, await _BlazorSupervisor.AddGenreAsync(input, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<GenreApiModel>> Put(int id, [FromBody] GenreApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await _BlazorSupervisor.GetGenreByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                var errors = JsonConvert.SerializeObject(ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage));
                Debug.WriteLine(errors);

                if (await _BlazorSupervisor.UpdateGenreAsync(input, ct))
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
        public async Task<ActionResult> Delete(int id, CancellationToken ct = default)
        {
            try
            {
                if (await _BlazorSupervisor.GetGenreByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                if (await _BlazorSupervisor.DeleteGenreAsync(id, ct))
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