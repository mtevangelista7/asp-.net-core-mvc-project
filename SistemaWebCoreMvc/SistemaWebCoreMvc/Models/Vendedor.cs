using System.Linq;

namespace SistemaWebCoreMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataAniversario, double salarioBase, Departamento departamento)
        { 
            Id = id;
            Nome = nome;
            Email = email;
            DataAniversario = dataAniversario;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVendas(Venda venda)
        {
            Vendas.Add(venda);
        }

        public void RemoverVendas(Venda venda)
        {
            Vendas.Remove(venda);
        }

        // Metodo que retorna o total de vendas durante um periodo, de um determinado vendedor
        public double TotalVendasVendedor(DateTime inicial, DateTime final)
        {
            // Filtre uma lista de vendas tal que a data da venda seja menor que a data de inicio passada
            // e menor que a data final passada. E me retorne a soma total das vendas
            return Vendas.Where(venda => venda.Data >= inicial && venda.Data <= final).Sum(venda => venda.Total);
        }
    }

}
