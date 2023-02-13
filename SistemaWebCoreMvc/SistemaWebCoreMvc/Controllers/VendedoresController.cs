using Microsoft.AspNetCore.Mvc;

namespace SistemaWebCoreMvc.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
