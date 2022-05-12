using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class VendaController : ControllerBase
{
    public static List<Venda> VendaDaClasse { get; set; } = new List<Venda>();

    [HttpPost()]
    public IActionResult SetVenda(Venda venda)
    {
        VendaDaClasse.Add(venda);
        return Ok(VendaDaClasse);
    }
    [HttpGet()]
    public IActionResult GetVenda()
    {
        return Ok(VendaDaClasse);
    }
    [HttpDelete]
    public IActionResult DeleteVendaDaClasse(Venda venda)
    {
        VendaDaClasse.Remove(venda);
        return Ok(venda);
    }

}
