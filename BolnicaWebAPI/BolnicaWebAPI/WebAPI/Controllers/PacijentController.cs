using BolnicaLibrary;
using Microsoft.AspNetCore.Mvc;
using BolnicaLibrary;
using BolnicaLibrary.DTOs;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PacijentController : ControllerBase
{
    public PacijentController()
    {
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpGet("PruzmiPacijente")]
    public async Task<ActionResult> PruzmiPacijente()
    {
        var (isError, pacijenti, error) = await DataProvider.VratiPacijenteAsync();

        if (isError)
        {
            return BadRequest(error);
        }

        return Ok(pacijenti);
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("IzmeniStacionarnogPacijenta")]
    public async Task<ActionResult> IzmeniStacionarnogPacijenta([FromBody] StacionarniView pacijent)
    {
        var data = await DataProvider.IzmeniStacionarnogAsync(pacijent);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspesno izmenjen stacionarni pacijent sa ID: {pacijent.Mat_br}");
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPut("IzmeniAmbulantnogPacijenta")]
    public async Task<ActionResult> IzmeniAmbulantnogPacijenta([FromBody] AmbulantniView pacijent)
    {
        var data = await DataProvider.IzmeniAmbulantnogAsync(pacijent);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Uspesno izmenjen ambulantni pacijent sa ID: {pacijent.Mat_br}");
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiPacijenta/{pacijentId}")]
    public async Task<ActionResult> IzbrisiMedicinskoOsoblje(int pacijentId)
    {
        var data = await DataProvider.ObrisiPacijentaAsync(pacijentId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisan pacijent sa ID: {pacijentId}");
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiStacionarnogPacijenta/{pacijentId}")]
    public async Task<ActionResult> IzbrisiStacionarnogPacijenta(int pacijentId)
    {
        var data = await DataProvider.ObrisiStacionarnogAsync(pacijentId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisan stacionarni pacijent sa ID: {pacijentId}");
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpDelete("IzbrisiAmbulantnogPacijenta/{pacijentId}")]
    public async Task<ActionResult> IzbrisiAmbulantnogPacijenta(int pacijentId)
    {
        var data = await DataProvider.ObrisiAmbulantnogAsync(pacijentId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return Ok($"Izbrisan ambulantni pacijent sa ID: {pacijentId}");
    }
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("DodajStacionarnogPacijenta/{lekarId}")]
    public async Task<ActionResult> DodajStacionarnogPacijenta([FromBody] StacionarniView pacijent, int lekarId)
    {
        var (isError, id, error) = await DataProvider.SacuvajStacionarnogBezLekaraAsync(pacijent);

        if (isError)
        {
            return BadRequest(error);
        }

        var data = await DataProvider.PoveziStacionarnogILekaraAsync(id, lekarId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return StatusCode(201, $"Upisan stacionarni pacijent, sa ID: {id}");
    }
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("DodajAmbulantnogPacijenta/{lekarId}")]
    public async Task<ActionResult> DodajAmbulantnogPacijenta([FromBody] AmbulantniView pacijent, int lekarId)
    {
        var (isError, id, error) = await DataProvider.SacuvajAmbulantnogBezLekaraAsync(pacijent);

        if (isError)
        {
            return BadRequest(error);
        }

        var data = await DataProvider.PoveziAmbulantnogILekaraAsync(id, lekarId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return StatusCode(201, $"Upisan ambulantni pacijent, sa ID: {id}");
    }
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost("DodajStacionarnogSpecijalisti/{lekarId}")]
    public async Task<ActionResult> DodajStacionarnogSpecijalisti([FromBody] StacionarniView pacijent, int lekarId)
    {
        var (isError, id, error) = await DataProvider.SacuvajStacionarnogBezSpecijalisteAsync(pacijent);

        if (isError)
        {
            return BadRequest(error);
        }

        var data = await DataProvider.PoveziStacionarnogISpecijalistuAsync(id, lekarId);

        if (data.IsError)
        {
            return BadRequest(data.Error);
        }

        return StatusCode(201, $"Upisan stacionarni pacijent, sa ID: {id}");
    }
   

}
