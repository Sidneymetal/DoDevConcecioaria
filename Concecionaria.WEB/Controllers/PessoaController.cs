using ConcecionariaDoDev;
using Microsoft.AspNetCore.Mvc;

namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    public static List<Pessoa> PessoaDaClasse { get; set; } = new List<Pessoa>();

    [HttpPost()]
    public IActionResult SetPessoa(Pessoa pessoa)
    {
        PessoaDaClasse.Add(pessoa);
        return Ok(PessoaDaClasse);
    }
}

