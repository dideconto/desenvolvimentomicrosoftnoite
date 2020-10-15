using Microsoft.AspNetCore.Mvc;

namespace VendasWeb.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string ActionDois()
        {
            return "Retorno de um texto";
        }
    }
}
