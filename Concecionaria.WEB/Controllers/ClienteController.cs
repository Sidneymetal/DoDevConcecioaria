using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    public static List<Cliente> ClienteDaClasse { get; set; } = new List<Cliente>();

    [HttpPost()]
    public IActionResult SetCliente(Cliente cliente)
    {
        ClienteDaClasse.Add(cliente);
        return Ok(ClienteDaClasse);
    }
    [HttpGet()]
    public IActionResult GetCliente()
    {
        return Ok(ClienteDaClasse);
    }
    [HttpDelete]
    public IActionResult DeletePessoaDaClasse(Cliente cliente)
    {
        ClienteDaClasse.Remove(cliente);
        return Ok(cliente);
    }

    [HttpPost("ValidarTelefone")]
    public IActionResult ValidarTelefoneReal(Cliente cliente)
    {
        try
        {
            cliente.ValidarTelefone(cliente.GetTelefone());
            ClienteDaClasse.Add(cliente);
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
