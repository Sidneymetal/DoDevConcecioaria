using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class FuncionarioController : ControllerBase
{
    public static List<Funcionario> FuncionarioDaClasse { get; set; } = new List<Funcionario>();

    [HttpPost()]
    public IActionResult SetFuncionario(Funcionario funcionario)
    {
        FuncionarioDaClasse.Add(funcionario);
        return Ok(FuncionarioDaClasse);
    }
    [HttpGet()]
    public IActionResult GetFuncionario()
    {
        return Ok(FuncionarioDaClasse);
    }
    [HttpDelete]
    public IActionResult DeletePessoaDaClasse(Funcionario funcionario)
    {
        FuncionarioDaClasse.Remove(funcionario);
        return Ok(funcionario);
    }

}
