using Concecionaria.WEB.DTOs;
using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class VendaController : ControllerBase
{
    public static List<VendaDTO> VendaDaClasse { get; set; } = new List<VendaDTO>();
    public ILogger<VendaController> Log { get; set;}
    public VendaController(ILogger<VendaController> log)
    {
        Log = log;
    }
    [HttpPost("Validar Set Venda.")]
    public IActionResult SetVenda(VendaDTO vendaDto)
    {
        try
        {
            var venda = new Venda(vendaDto.Comprador, vendaDto.Vendedor, 
            vendaDto.Veiculo, vendaDto.FormaDePagamento, vendaDto.ValorFinal);
            VendaDaClasse.Add(vendaDto);
            return Ok(VendaDaClasse);
        }
        catch (System.Exception ex)
        {   
            Log.LogError(ex.Message);
            return BadRequest(ex.Message);
        }
    }

}
