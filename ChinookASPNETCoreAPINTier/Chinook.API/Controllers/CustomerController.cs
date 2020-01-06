﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Newtonsoft.Json;
using System.Diagnostics;
using Chinook.Domain.Supervisor;
using Chinook.Domain.ApiModels;
using Microsoft.AspNetCore.Cors;

namespace Chinook.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly IChinookSupervisor _chinookSupervisor;

        public CustomerController(IChinookSupervisor chinookSupervisor)
        {
            _chinookSupervisor = chinookSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<CustomerApiModel>))]
        public async Task<ActionResult<List<CustomerApiModel>>> Get(CancellationToken ct = default)
        {
            try
            {
                return new ObjectResult(await _chinookSupervisor.GetAllCustomerAsync(ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(CustomerApiModel))]
        public async Task<ActionResult<CustomerApiModel>> Get(int id, CancellationToken ct = default)
        {
            try
            {
                var customer = await _chinookSupervisor.GetCustomerByIdAsync(id, ct);
                if ( customer == null)
                {
                    return NotFound();
                }

                return Ok(customer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("supportrep/{id}")]
        [Produces(typeof(List<CustomerApiModel>))]
        public async Task<ActionResult<CustomerApiModel>> GetBySupportRepId(int id, CancellationToken ct = default)
        {
            try
            {
                var rep = await _chinookSupervisor.GetEmployeeByIdAsync(id, ct);
                if ( rep == null)
                {
                    return NotFound();
                }

                return Ok(rep);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<CustomerApiModel>> Post([FromBody] CustomerApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, await _chinookSupervisor.AddCustomerAsync(input, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CustomerApiModel>> Put(int id, [FromBody] CustomerApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await _chinookSupervisor.GetCustomerByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                var errors = JsonConvert.SerializeObject(ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage));
                Debug.WriteLine(errors);

                if (await _chinookSupervisor.UpdateCustomerAsync(input, ct))
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
                if (await _chinookSupervisor.GetCustomerByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                if (await _chinookSupervisor.DeleteCustomerAsync(id, ct))
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