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
    public class InvoiceLineController : Controller
    {
        private readonly IBlazorSupervisor _BlazorSupervisor;

        public InvoiceLineController(IBlazorSupervisor BlazorSupervisor)
        {
            _BlazorSupervisor = BlazorSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<InvoiceLineApiModel>))]
        public async Task<ActionResult<List<InvoiceLineApiModel>>> Get(CancellationToken ct = default)
        {
            try
            {
                return new ObjectResult(await _BlazorSupervisor.GetAllInvoiceLineAsync(ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(InvoiceLineApiModel))]
        public async Task<ActionResult<InvoiceLineApiModel>> Get(int id, CancellationToken ct = default)
        {
            try
            {
                var invoiceLine = await _BlazorSupervisor.GetInvoiceLineByIdAsync(id, ct);
                if ( invoiceLine == null)
                {
                    return NotFound();
                }

                return Ok(invoiceLine);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("invoice/{id}")]
        [Produces(typeof(List<InvoiceLineApiModel>))]
        public async Task<ActionResult<InvoiceLineApiModel>> GetByInvoiceId(int id, CancellationToken ct = default)
        {
            try
            {
                var invoice = await _BlazorSupervisor.GetInvoiceByIdAsync(id, ct);
                if ( invoice == null)
                {
                    return NotFound();
                }

                return Ok(invoice);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("track/{id}")]
        [Produces(typeof(List<InvoiceLineApiModel>))]
        public async Task<ActionResult<InvoiceLineApiModel>> GetByArtistId(int id, CancellationToken ct = default)
        {
            try
            {
                var track = await _BlazorSupervisor.GetTrackByIdAsync(id, ct);
                if (track == null)
                {
                    return NotFound();
                }

                return Ok(track);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<InvoiceLineApiModel>> Post([FromBody] InvoiceLineApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, await _BlazorSupervisor.AddInvoiceLineAsync(input, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<InvoiceLineApiModel>> Put(int id, [FromBody] InvoiceLineApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await _BlazorSupervisor.GetInvoiceLineByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                var errors = JsonConvert.SerializeObject(ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage));
                Debug.WriteLine(errors);

                if (await _BlazorSupervisor.UpdateInvoiceLineAsync(input, ct))
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
                if (await _BlazorSupervisor.GetInvoiceLineByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                if (await _BlazorSupervisor.DeleteInvoiceLineAsync(id, ct))
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