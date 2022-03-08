namespace Labrasa.API.Domain.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public double ValorPedido { get; set; }
        public int ComandaPedidoId { get; set; }
        public Comanda ComandaPedido { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
