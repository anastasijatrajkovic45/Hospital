using BolnicaLibrary;
using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary.DTOs;
using System.ComponentModel;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SmenaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSmene")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetSmene()
    {
        (bool isError, var smene, string? error) = DataProvider.VratiSmene();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(smene);
    }

    [HttpPost]
    [Route("DodajSmenu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DodajSmenu([FromBody] SmenaView p)
    {
        var data = await DataProvider.DodajSmenuAsync(p);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno dodata smena. Tip smene: {p.Tip_smene}");
    }

    [HttpPut]
    [Route("PromeniSmenu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PromeniSmenu([FromBody] SmenaView p)
    {
        (bool isError, var smene, string? error) = await DataProvider.AzurirajSmenuAsync(p);

        if (isError)
        {
            return BadRequest(error);
        }

        if (smene == null)
        {
            return BadRequest("Smena nije validna.");
        }

        return Ok($"Uspešno ažurirana smena. ID: {smene.Id}");
    }

    [HttpDelete]
    [Route("IzbrisiSmenu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> IzbrisiSmenu(int id)
    {
        var data = await DataProvider.ObrisiSmennuAsync(id);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno obrisana smena. ID smene: {id}");
    }
}
