namespace Labrasa.API.Domain.Models
{
    public class Comanda
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataHoraAbertura { get; set; }
        public double DataHoraFechamento { get; set; }
        public bool StatusComanda { get; set; }
        public List<Pedido> PedidosComanda { get; set; }
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }
    }
}
