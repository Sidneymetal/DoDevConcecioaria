using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<Cliente> ClienteDaClasse { get; set; } = new List<Cliente>();

    [HttpPost("ValidarTelefone")]
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
    [HttpPost("ValidarEmail")]
    public IActionResult ValidarEmailReal(Cliente cliente)
    {
        try
        {
            cliente.ValidarEmail(cliente.GetEmail());
            ClienteDaClasse.Add(cliente);
            return Ok(ClienteDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
