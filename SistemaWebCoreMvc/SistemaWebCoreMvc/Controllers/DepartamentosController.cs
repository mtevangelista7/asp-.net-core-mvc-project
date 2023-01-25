using Microsoft.AspNetCore.Mvc;
using SistemaWebCoreMvc.Models;


namespace SistemaWebCoreMvc.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            // Criando uma lista de departamentos e adicionando elementos
            List<Departamento> listaDepartamentos = new List<Departamento>();
            listaDepartamentos.Add(new Departamento { Id = 1, Nome = "Eletrônicos" });
            listaDepartamentos.Add(new Departamento { Id = 2, Nome = "Moda" });

            // Enviando a lista para a view
            return View(listaDepartamentos);
        }
    }
}
