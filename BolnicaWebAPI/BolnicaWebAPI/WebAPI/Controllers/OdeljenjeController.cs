using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary;
using BolnicaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class OdeljenjeController : ControllerBase
{
    public OdeljenjeController()
    {
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpGet("PruzmiSvaOdeljenja")]
    public async Task<ActionResult> VratiSvaOdeljenja()
    {
        var (isError, odeljenja, error) = await DataProvider.VratiSvaOdeljenjaAsync();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(odeljenja);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("KreirajOdeljenje/{specijalistaID}")]
    public async Task<ActionResult> KreirajOdeljenje([FromBody] OdeljenjeView odeljenje, int specijalistaID)
    {
        var (isError, sifra, error) = await DataProvider.SacuvajOdeljenjeBezSpecijalisteAsync(odeljenje);  

        if (isError)
        {
            return BadRequest(error);
        }

        var data = await DataProvider.PoveziOdeljenjeISpecijalistuAsync(sifra, specijalistaID);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return StatusCode(201, $"Upisano odeljenje, sa ID: {sifra}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("IzmenaOdeljenja")]
    public async Task<ActionResult> IzmenaOdeljenja([FromBody] OdeljenjeView odeljenje)
    {
        var data = await DataProvider.IzmeniOdeljenjeAsync(odeljenje);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Upisano izmenjeno odeljenje, sa ID: {odeljenje.Sifra}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiOdeljenje/{idOdeljenja}")]
    public async Task<ActionResult> IzbrisiOdeljenje(int idOdeljenja)
    {
        var data = await DataProvider.ObrisiOdeljenjeAsync(idOdeljenja);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisano odeljenje, sa ID: {idOdeljenja}");
    }
}
