using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<Veiculo> ClienteDaClasse { get; set; } = new List<Veiculo>();

    [HttpPost("ValidarAno")]
    public IActionResult ValidarValorCarro(Veiculo veiculo)
    {
        try
        {
            veiculo.ValidarAno(veiculo.GetAno());
            ClienteDaClasse.Add(veiculo);
            return Ok(ClienteDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }    
}
