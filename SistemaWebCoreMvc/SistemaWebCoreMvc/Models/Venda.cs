using SistemaWebCoreMvc.Models.Enums;

namespace SistemaWebCoreMvc.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Venda()
        {
        }

        public Venda(int id, DateTime data, double total, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
