using BolnicaLibrary;
using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary;
using BolnicaLibrary.DTOs;
using BolnicaLibrary.Entiteti;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class NemedicinskoController : ControllerBase
{
    public NemedicinskoController()
    {
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpGet("PruzmiNemedicinskoOsoblje")]
    public async Task<ActionResult> PruzmiNemedicinskoOsoblje()
    {
        var (isError, nemedicinsko, error) = DataProvider.VratiSvaNemedicinska();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(nemedicinsko);
    }
    [HttpPost]
    [Route("DodajNemedicnskuOsobu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DodajNemedicnskuOsobu([FromBody] NemedicinskoView p)
    {
        var data = DataProvider.DodajNemedicinsko(p);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno dodata nemedicinska osoba. ID: {p.Mat_br} ");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("IzmeniNemedicinsko")]
    public async Task<ActionResult> IzmeniNemedicinsko([FromBody] NemedicinskoView nemedicinsko)
    {
        var data = await DataProvider.IzmeniNemedicinskoAsync(nemedicinsko);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Upisana izmenjena nemedicinska osoba sa ID: {nemedicinsko.Mat_br}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiNemedicinskoOsoblje/{nemedicinskoId}")]
    public async Task<ActionResult> IzbrisiNemedicinskoOsoblje(int nemedicinskoId)
    {
        var data = await DataProvider.ObrisiNemedicinskoAsync(nemedicinskoId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisana medicinska osoba, sa ID: {nemedicinskoId}");
    }
}
