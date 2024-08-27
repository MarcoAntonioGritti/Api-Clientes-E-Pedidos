namespace ApiGerenciamentoClientesPedidos.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataDoPedido { get; set; }
        public decimal valorTotalPedido { get; set; }
    }
}
