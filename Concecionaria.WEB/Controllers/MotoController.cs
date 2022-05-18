using Concecionaria.WEB.DTOs;
using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class MotoController : ControllerBase
{
    public static List<MotoDTO> MotoDaClasse { get; set; } = new List<MotoDTO>();

    [HttpPost("Validar Set Moto")]
    public IActionResult SetMotoDaClass(MotoDTO motoDTO)
    {
        try
        {
            var moto = new Moto (motoDTO.Cilindrada, motoDTO.Partida, motoDTO.Marca, 
            motoDTO.Modelo, motoDTO.Ano, motoDTO.Quilometragem, motoDTO.Cor, motoDTO.Valor);
            MotoDaClasse.Add(motoDTO);
            return Ok(MotoDaClasse);
        }
        catch (System.Exception ex)
        {
             return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    public IActionResult DeleteMotoDaClasse(MotoDTO motoDTO)
    {
        MotoDaClasse.Remove(motoDTO);
        return Ok(motoDTO);
    }

}
