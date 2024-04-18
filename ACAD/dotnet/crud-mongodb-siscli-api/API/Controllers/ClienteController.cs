using Microsoft.AspNetCore.Mvc;
using Models;
using MongoDB.Driver;

namespace API.Controllers;

[ApiController]
[Route("api/clientes")]
public class ClienteController : ControllerBase
{
    private readonly IMongoCollection<Cliente> _clientes;

    public ClienteController(IMongoDatabase database)
    {
        _clientes = database.GetCollection<Cliente>("clientes");
    }

    [HttpGet("listar")]
    public async Task<IActionResult> ListarClientes()
    {
        try
        {
            var clientes = await _clientes.Find(c => true).ToListAsync();
            return Ok(clientes);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpPost("adicionar")]
    public async Task<IActionResult> AdicionarCliente([FromBody] Cliente cliente) // Método para adicionar um cliente
    {
        return Ok("Novo cliente adicionado com sucesso ao MongoDB");
    }

    [HttpPut("atualizar")]
    public async Task<IActionResult> AtualizarCliente([FromBody] Cliente cliente) // Método para adicionar um cliente
    {
        return Ok("Atualizado com sucesso.");
    }

    [HttpDelete("deletar")]
    public async Task<IActionResult> DeletarCliente([FromBody] Cliente cliente) // Método para adicionar um cliente
    {
        return Ok("Apagado com sucesso.");
    }

}