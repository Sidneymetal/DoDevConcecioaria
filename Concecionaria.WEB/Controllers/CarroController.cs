using Concecionaria.WEB.DTOs;
using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;
namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    public static List<CarroDTO> CarroDaClasse { get; set; } = new List<CarroDTO>();

    [HttpPost("Validar Set Carro")]
    public IActionResult SetCarro(CarroDTO carroDTO)
    {
       try
       {
           var carro = new Carro (carroDTO.TransmissaoAutomatica, carroDTO.Combustivel, 
           carroDTO.Marca, carroDTO.Modelo, carroDTO.Ano, carroDTO.Quilometragem, carroDTO.Cor, carroDTO.Valor);
           CarroDaClasse.Add(carroDTO);
           return Ok(CarroDaClasse);
       }
       catch (System.Exception ex)
       {
            return BadRequest(ex.Message);
       }
    }
    
    [HttpDelete]
    public IActionResult DeletePessoaDaClasse(CarroDTO carroDTO)
    {
        CarroDaClasse.Remove(carroDTO);
        return Ok(carroDTO);
    }

}
