using BolnicaLibrary;
using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary.DTOs;
using System.ComponentModel;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StolicaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiStomatoloskeStolice")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetStolice()
    {
        (bool isError, var stolice, string? error) = DataProvider.VratiSveStolice();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(stolice);
    }

    [HttpPost]
    [Route("DodajStomatoloskuStolicu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> AddStolica([FromBody] Stomatoloska_stolicaView p)
    {
        var data = await DataProvider.DodajStolicuAsync(p);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno dodata stolica. Proizvodjac: {p.Proizvodjac}");
    }

    [HttpPut]
    [Route("PromeniStomatoloskuStolicu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> ChangeStolica([FromBody] Stomatoloska_stolicaView p)
    {
        (bool isError, var stolice, string? error) = await DataProvider.AzurirajStolicuAsync(p);

        if (isError)
        {
            return BadRequest(error);
        }

        if (stolice == null)
        {
            return BadRequest("Stolica nije validna.");
        }

        return Ok($"Uspešno ažurirana stomatoloska stolica. Proizvodjac: {stolice.Proizvodjac}");
    }

    [HttpDelete]
    [Route("IzbrisiStomatoloskuStolicu/{proizvodjac}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DeleteStolica(string proizvodjac)
    {
        var data = await DataProvider.ObrisiStolicuAsync(proizvodjac);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno obrisana stomatoloska stolica. Proizvodjac: {proizvodjac}");
    }
}
