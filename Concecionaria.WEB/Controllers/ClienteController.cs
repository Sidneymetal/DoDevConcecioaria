using Concecionaria.WEB.DTOs;
using ProjetoConcecionaria.Lib.Models;
using ProjetoConcecionaria.Lib.Exceptions;
using Microsoft.AspNetCore.Mvc;


namespace Concecionaria.WEB.Controllers;

[ApiController]
[Route("[controller]")]

public class ClienteController : ControllerBase
{
    public static List<ClienteDTO> ClienteDaClasse { get; set; } = new List<ClienteDTO>();

    [HttpPost("Validar Set Cliente")]
    public IActionResult SetCliente(ClienteDTO clienteDto)
    {
        try
        {
            var cliente = new Cliente(clienteDto.Email, clienteDto.Telefone,
            clienteDto.Nome, clienteDto.Cpf, clienteDto.DataDeNascimento);
            ClienteDaClasse.Add(clienteDto);
            return Ok(ClienteDaClasse);
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
