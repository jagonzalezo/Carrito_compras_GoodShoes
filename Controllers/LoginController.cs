using Microsoft.AspNetCore.Mvc;

namespace Carrito_Compras_Zapatos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(string usuario, string password)
        {
            // Por ahora solo validación simple para la prueba
            if (usuario == "admin" && password == "1234")
            {
                TempData["Mensaje"] = "Ingreso exitoso";
                return RedirectToAction("Index", "Tienda");
            }
            else
            {
                ViewBag.Error = "Usuario o contraseña incorrectos.";
                return View("Index");
            }
        }

        public IActionResult Registrar()
        {
            return View();
        }
    }
}