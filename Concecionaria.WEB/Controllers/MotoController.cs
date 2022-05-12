using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class MotoController : ControllerBase
{
    public static List<Moto> MotoDaClasse { get; set; } = new List<Moto>();

    [HttpPost()]
    public IActionResult SetMoto(Moto moto)
    {
        MotoDaClasse.Add(moto);
        return Ok(MotoDaClasse);
    }
    [HttpGet()]
    public IActionResult GetMoto()
    {
        return Ok(MotoDaClasse);
    }
    [HttpDelete]
    public IActionResult DeleteMotoDaClasse(Moto moto)
    {
        MotoDaClasse.Remove(moto);
        return Ok(moto);
    }

}
