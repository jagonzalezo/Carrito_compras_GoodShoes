using Microsoft.AspNetCore.Mvc;

namespace Carrito_Compras_Zapatos.Controllers
{
    public class TiendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}