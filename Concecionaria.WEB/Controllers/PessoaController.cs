using Concecionaria.WEB.DTOs;
using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    public static List<PessoaDTO> PessoaDaClasse { get; set; } = new List<PessoaDTO>();
    public ILogger<PessoaController> Log { get; set; }
    public PessoaController(ILogger<PessoaController> log)
    {
        Log = log;
    }
    [HttpPost("Validar Set Pessoa")]
    public IActionResult SetPessoa(PessoaDTO pessoaDTO)
    {
       try
       {
            var pessoa = new Pessoa (pessoaDTO.Nome, pessoaDTO.Cpf, pessoaDTO.DataDeNascimento);
            PessoaDaClasse.Add(pessoaDTO);
            return Ok(PessoaDaClasse);
       }
       catch (System.Exception ex)
       {    
           Log.LogError(ex.Message);
            return BadRequest(ex.Message);
       }
    }
    
    [HttpDelete]
    public IActionResult DeletePessoaDaClasse()
    {        
        var ContagemPessoa = PessoaDaClasse.Count<PessoaDTO>();
        PessoaDaClasse.RemoveAt(ContagemPessoa - 1);
        return Ok(PessoaDaClasse);
    }
    
}

