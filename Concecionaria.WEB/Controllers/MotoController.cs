using Concecionaria.WEB.DTOs;
using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class MotoController : ControllerBase
{
    public static List<MotoDTO> MotoDaClasse { get; set; } = new List<MotoDTO>();
    public ILogger<MotoController> Log { get; set;} 
    public MotoController(ILogger<MotoController> log)
    {
        Log = log;
    }
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
            Log.LogError(ex.Message);
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
