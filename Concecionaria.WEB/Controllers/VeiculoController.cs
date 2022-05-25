using Concecionaria.WEB.DTOs;
using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;
namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<VeiculoDTO> VeiculoDaClasse { get; set; } = new List<VeiculoDTO>();
    public ILogger<VeiculoController> Log {get; set;}
    public VeiculoController(ILogger<VeiculoController> log)
    {
        Log = log;
    }
    [HttpPost("Validar Set Veículo")]
    public IActionResult SetVeiculo(VeiculoDTO veiculoDTO)
    {
        try
        {
            var veiculo = new Veiculo(veiculoDTO.Marca, veiculoDTO.Modelo, 
            veiculoDTO.Ano, veiculoDTO.Quilometragem, veiculoDTO.Cor, veiculoDTO.Valor);
            VeiculoDaClasse.Add(veiculoDTO);
            return Ok(VeiculoDaClasse);
        }
        catch (System.Exception ex)
        {   
            Log.LogError(ex.Message);
            return BadRequest(ex.Message);
        }
    }
}
