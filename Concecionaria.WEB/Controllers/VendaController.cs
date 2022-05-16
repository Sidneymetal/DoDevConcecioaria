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
    [HttpPost("ValidarCarro")]
    public IActionResult ValidarValorCarro(Venda venda)
    {
        try
        {
           venda.ValidarValorCarro(venda.GetValorFinal());
            VendaDaClasse.Add(venda);
            return Ok(VendaDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost("ValidarMoto")]
    public IActionResult ValidarValorMoto(Venda venda)
    {
        try
        {
            venda.ValidarValorMoto(venda.GetValorFinal());
            VendaDaClasse.Add(venda);
            return Ok(VendaDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
