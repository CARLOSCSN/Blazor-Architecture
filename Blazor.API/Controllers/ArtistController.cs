﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using Newtonsoft.Json;
using System.Diagnostics;
using Domain.Supervisor;
using Domain.ApiModels;
using Microsoft.AspNetCore.Cors;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class ArtistController : Controller
    {
        private readonly IBlazorSupervisor _BlazorSupervisor;

        public ArtistController(IBlazorSupervisor BlazorSupervisor)
        {
            _BlazorSupervisor = BlazorSupervisor;
        }

        [HttpGet]
        [Produces(typeof(List<ArtistApiModel>))]
        public async Task<ActionResult<List<ArtistApiModel>>> Get(CancellationToken ct = default)
        {
            try
            {
                return new ObjectResult(await _BlazorSupervisor.GetAllArtistAsync(ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [Produces(typeof(ArtistApiModel))]
        public async Task<ActionResult<ArtistApiModel>> Get(int id, CancellationToken ct = default)
        {
            try
            {
                var artist = await _BlazorSupervisor.GetArtistByIdAsync(id, ct);
                if ( artist == null)
                {
                    return NotFound();
                }

                return Ok(artist);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ArtistApiModel>> Post([FromBody] ArtistApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();

                return StatusCode(201, await _BlazorSupervisor.AddArtistAsync(input, ct));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ArtistApiModel>> Put(int id, [FromBody] ArtistApiModel input,
            CancellationToken ct = default)
        {
            try
            {
                if (input == null)
                    return BadRequest();
                if (await _BlazorSupervisor.GetArtistByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                var errors = JsonConvert.SerializeObject(ModelState.Values
                    .SelectMany(state => state.Errors)
                    .Select(error => error.ErrorMessage));
                Debug.WriteLine(errors);

                if (await _BlazorSupervisor.UpdateArtistAsync(input, ct))
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
                if (await _BlazorSupervisor.GetAlbumByIdAsync(id, ct) == null)
                {
                    return NotFound();
                }

                if (await _BlazorSupervisor.DeleteAlbumAsync(id, ct))
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