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

}
