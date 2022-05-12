using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    public static List<Pessoa> PessoaDaClasse { get; set; } = new List<Pessoa>();

    [HttpGet()]
    public IActionResult SetPessoa(Pessoa pessoa)
    {
        PessoaDaClasse.Add(pessoa);
        return Ok(PessoaDaClasse);
    }
}

