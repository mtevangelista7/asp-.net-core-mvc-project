using Microsoft.AspNetCore.Mvc;
using SistemaWebCoreMvc.Models;
using System.Runtime.Intrinsics.X86;


namespace SistemaWebCoreMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            // Instanciando uma nova lista de departamentos
            List<Departamento> listaDepartamentos = new List<Departamento>();

            //adicionando departamentos na lista
            listaDepartamentos.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            listaDepartamentos.Add(new Departamento { Id = 2, Nome = "Moda" });

            // Enviando a lista para a view
            return View(listaDepartamentos);
        }
    }
}
