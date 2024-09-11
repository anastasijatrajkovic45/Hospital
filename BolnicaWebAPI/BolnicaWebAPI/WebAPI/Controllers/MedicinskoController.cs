using BolnicaLibrary;
using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary;
using BolnicaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicinskoController : ControllerBase
{
    public MedicinskoController()
    {
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpGet("PruzmiMedicinskoOsoblje")]
    public async Task<ActionResult> PruzmiMedicinskoOsoblje()
    {
        var (isError, medicinsko, error) = DataProvider.VratiSvaMedicinska();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(medicinsko);
    }

    [HttpPost]
    [Route("DodajMedicnskuOsobu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> DodajMedicnskuOsobu([FromBody] MedicinskoView p)
    {
        var data = DataProvider.DodajMedicinsko(p);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspešno dodata medicinska osoba. Ime: {p.Mat_br} ");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("IzmeniMedicinsko")]
    public async Task<ActionResult> IzmeniMedicinsko([FromBody] MedicinskoView medicinsko)
    {
        var data = await DataProvider.IzmeniMedicinskoAsync(medicinsko);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Upisana izmenjena medicinska osoba sa ID: {medicinsko.Mat_br}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiMedicinskoOsoblje/{medicinskoId}")]
    public async Task<ActionResult> IzbrisiMedicinskoOsoblje(int medicinskoId)
    {
        var data = await DataProvider.ObrisiMedicinskoAsync(medicinskoId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisana medicinska osoba, sa ID: {medicinskoId}");
    }
}
