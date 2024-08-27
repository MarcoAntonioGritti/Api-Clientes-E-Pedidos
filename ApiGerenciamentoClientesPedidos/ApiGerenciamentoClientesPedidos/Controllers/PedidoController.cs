using ApiGerenciamentoClientesPedidos.Context;
using ApiGerenciamentoClientesPedidos.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiGerenciamentoClientesPedidos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly GerenciamentoContext _context;

        public PedidoController(GerenciamentoContext context)
        {
            _context = context;
        }


        [HttpPost("CadastrarCliente")]
        public IActionResult CriaNovosPedidosCliente(Pedido novosPedidos)
        {
            _context.Add(novosPedidos);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ProcurarPedidoClientePorId), new { id = novosPedidos.Id }, novosPedidos);
        }

        [HttpGet("ProcurarPedidoClientePorId/{id}")]
        public IActionResult ProcurarPedidoClientePorId(int id)
        {
            var pedidosProcurados = _context.Pedidos.Find(id);

            if (pedidosProcurados == null)
                return NotFound();

            return Ok(pedidosProcurados);
        }

        [HttpPut("AtualizarPedidosCliente/{id}")]
        public IActionResult AtualizarCliente(int id, Pedido pedido)
        {
            var pedidosClienteAtualizado = _context.Pedidos.Find(id);

            if (pedidosClienteAtualizado == null)
                return NotFound();

            pedidosClienteAtualizado.DataDoPedido = pedido.DataDoPedido;
            pedidosClienteAtualizado.valorTotalPedido = pedido.valorTotalPedido;

            _context.Pedidos.Update(pedidosClienteAtualizado);
            _context.SaveChanges();

            return Ok(pedidosClienteAtualizado);
        }

        [HttpDelete("DeletarPedidosCliente/{id}")]
        public IActionResult DeletarPedidosCliente(int id)
        {
            var pedidosClienteDeletado = _context.Pedidos.Find(id);

            if (pedidosClienteDeletado == null)
                return NotFound();

            _context.Pedidos.Remove(pedidosClienteDeletado);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
