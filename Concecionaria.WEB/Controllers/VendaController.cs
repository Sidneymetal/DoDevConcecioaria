using Concecionaria.WEB.DTOs;
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
   
    [HttpPost("Validar Set Venda.")]
    public IActionResult SetVenda(VendaDTO vendaDto)
    {
        try
        {
            var venda = new Venda(vendaDto.Comprador, vendaDto.Vendedor, vendaDto.Veiculo, vendaDto.FormaDePagamento, vendaDto.ValorFinal);
            VendaDaClasse.Add(venda);
            return Ok (VendaDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
