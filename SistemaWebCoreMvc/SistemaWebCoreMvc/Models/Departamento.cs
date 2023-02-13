using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebCoreMvc.Models
{
    public class Departamento
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendador(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendasDepartamento(DateTime inicial, DateTime final)
        {
            // Retorna a soma total de vendas de todos os vendedores do departamento
            // Chamando o metodo que calcula o total de venda de cada vendedor em determinado periodo
            return Vendedores.Sum(Vendedor => Vendedor.TotalVendasVendedor(inicial, final));
        }
    } 
}
