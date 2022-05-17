using Concecionaria.WEB.DTOs;
using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;
namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]

public class VeiculoController : ControllerBase
{
    public static List<Veiculo> VeiculoDaClasse { get; set; } = new List<Veiculo>();

    [HttpPost("ValidarAno")]
    public IActionResult ValidarValorCarro(Veiculo veiculo)
    {
        try
        {
            veiculo.ValidarAno(veiculo.GetAno());
            VeiculoDaClasse.Add(veiculo);
            return Ok(VeiculoDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost("Validar Set Veículo")]
    public IActionResult SetVeiculo(VeiculoDTO veiculoDTO)
    {
        try
        {
            var veiculo = new Veiculo(veiculoDTO.Marca, veiculoDTO.Modelo, veiculoDTO.Ano, veiculoDTO.Quilometragem, veiculoDTO.Cor, veiculoDTO.Valor);
            VeiculoDaClasse.Add(veiculo);
            return Ok(VeiculoDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
