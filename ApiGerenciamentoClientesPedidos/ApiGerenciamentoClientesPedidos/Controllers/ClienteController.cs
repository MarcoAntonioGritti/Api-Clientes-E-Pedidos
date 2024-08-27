using ApiGerenciamentoClientesPedidos.Context;
using ApiGerenciamentoClientesPedidos.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiGerenciamentoClientesPedidos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly GerenciamentoContext _context;
        public ClienteController(GerenciamentoContext context)
        {
            _context = context;
        }

        [HttpPost("CadastrarCliente")]
        public IActionResult CadastrarCliente(Cliente clienteNovo)
        {
            _context.Add(clienteNovo);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ProcurarClientePorId), new { id = clienteNovo.Id}, clienteNovo);
        }

        [HttpGet("ProcurarClietePorId/{id}")]
        public IActionResult ProcurarClientePorId(int id)
        {
            var clienteProcurado = _context.Clientes.Find(id);

            if (clienteProcurado == null)
                return NotFound();

            return Ok(clienteProcurado);
        }

        [HttpPut("AtualizarCliente/{id}")]
        public IActionResult AtualizarCliente(int id, Cliente cliente)
        {
            var clienteAtualizado = _context.Clientes.Find(id);

            if(clienteAtualizado == null)
                return NotFound();

            clienteAtualizado.Nome = cliente.Nome;
            clienteAtualizado.Email = cliente.Email;
            clienteAtualizado.Telefone = cliente.Telefone;

            _context.Clientes.Update(clienteAtualizado);
            _context.SaveChanges();

            return Ok(clienteAtualizado);
        }

        [HttpDelete("DeletarCliente/{id}")]
        public IActionResult DeletarCliente(int id)
        {
            var clienteDeletado = _context.Clientes.Find(id);

            if(clienteDeletado == null)
                return NotFound();

            _context.Clientes.Remove(clienteDeletado);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

