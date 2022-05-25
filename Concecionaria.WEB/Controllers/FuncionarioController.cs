using Concecionaria.WEB.DTOs;
using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionarioController : ControllerBase
{
    public static List<FuncionarioDTO> FuncionarioDaClasse { get; set; } = new List<FuncionarioDTO>();
    public ILogger<FuncionarioController> Log { get; set; }
    public FuncionarioController(ILogger<FuncionarioController> log)
    {
        Log = log;
    }
    [HttpPost("Validar Set Funciáario")]

    public IActionResult SetFuncionario(FuncionarioDTO funcionarioDTO)
    {
        try
        {
            var funcionario = new Funcionario(funcionarioDTO.Cargo, funcionarioDTO.Nome,
            funcionarioDTO.Cpf, funcionarioDTO.DataDeNascimento);
            FuncionarioDaClasse.Add(funcionarioDTO);
            return Ok(FuncionarioDaClasse);
        }
        catch (System.Exception ex)
        {   
            Log.LogError(ex.Message);
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public IActionResult DeletePessoaDaClasse(FuncionarioDTO funcionarioDTO)
    {
        FuncionarioDaClasse.Remove(funcionarioDTO);
        return Ok(funcionarioDTO);
    }

}
