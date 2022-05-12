using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    public static List<Carro> CarroDaClasse { get; set; } = new List<Carro>();

    [HttpPost()]
    public IActionResult SetCarro(Carro carro)
    {
        CarroDaClasse.Add(carro);
        return Ok(CarroDaClasse);
    }
    [HttpGet()]
    public IActionResult GetCarro()
    {
        return Ok(CarroDaClasse);
    }
    [HttpDelete]
    public IActionResult DeletePessoaDaClasse(Carro carro)
    {
        CarroDaClasse.Remove(carro);
        return Ok(carro);
    }

}
