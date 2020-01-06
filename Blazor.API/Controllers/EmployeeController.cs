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
    public class EmployeeController : Controller
    {
        private readonly IBlazorSupervisor _BlazorSupervisor;

        public EmployeeController(IBlazorSupervisor BlazorSupervisor)
        {
            _BlazorSupervisor = BlazorSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<EmployeeApiModel>))]
        public async Task<ActionResult<List<EmployeeApiModel>>> Get(CancellationToken ct = default)
        {
            try
            {
                return new ObjectResult(await _BlazorSupervisor.GetAllEmployeeAsync(ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(EmployeeApiModel))]
        public async Task<ActionResult<EmployeeApiModel>> Get(int id, CancellationToken ct = default)
        {
            try
            {
                var employee = await _BlazorSupervisor.GetEmployeeByIdAsync(id, ct);
                if ( employee == null)
                {
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("reportsto/{id}")]
        [Produces(typeof(List<EmployeeApiModel>))]
        public async Task<ActionResult<List<EmployeeApiModel>>> GetReportsTo(int id, CancellationToken ct = default)
        {
            try
            {
                var employee = await _BlazorSupervisor.GetEmployeeByIdAsync(id, ct);
                if ( employee == null)
                {
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("directreports/{id}")]
        [Produces(typeof(EmployeeApiModel))]
        public async Task<ActionResult<EmployeeApiModel>> GetDirectReports(int id, CancellationToken ct = default)
        {
            try
            {
                var employee = await _BlazorSupervisor.GetEmployeeByIdAsync(id, ct);
                if ( employee == null)
                {
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeApiModel>> Post([FromBody] EmployeeApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, await _BlazorSupervisor.AddEmployeeAsync(input, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<EmployeeApiModel>> Put(int id, [FromBody] EmployeeApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await _BlazorSupervisor.GetEmployeeByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                var errors = JsonConvert.SerializeObject(ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage));
                Debug.WriteLine(errors);

                if (await _BlazorSupervisor.UpdateEmployeeAsync(input, ct))
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
                if (await _BlazorSupervisor.GetEmployeeByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                if (await _BlazorSupervisor.DeleteEmployeeAsync(id, ct))
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