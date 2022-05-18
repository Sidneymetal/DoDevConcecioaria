using Concecionaria.WEB.DTOs;
using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;
namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<VeiculoDTO> VeiculoDaClasse { get; set; } = new List<VeiculoDTO>();

    
    [HttpPost("Validar Set Veículo")]
    public IActionResult SetVeiculo(VeiculoDTO veiculoDTO)
    {
        try
        {
            var veiculo = new Veiculo(veiculoDTO.Marca, veiculoDTO.Modelo, veiculoDTO.Ano, veiculoDTO.Quilometragem, veiculoDTO.Cor, veiculoDTO.Valor);
            VeiculoDaClasse.Add(veiculoDTO);
            return Ok(VeiculoDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
