using Microsoft.AspNetCore.Mvc;
using SistemaWebCoreMvc.Models;
using System.Diagnostics;
using SistemaWebCoreMvc.Models.ViewModels;

namespace SistemaWebCoreMvc.Controllers
{
    // todos os controllers tem que herdar da classe Controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //IActionResult = retorna o resultado de uma ação
        //Repare que o nome dessas IActionResult são exatamente iguais aos nomes das páginas
        //Ou seja este controller Home, controla essas 3 paginas abaixo, e seu layout é definido lá na View
        public IActionResult Index()
        {
            /*
             * O que ocorre aqui é que o framework vai buscar na View uma pagina com este nome, no caso index
             * e faz a construção da pagina
             */
            return View(); //method builder
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}