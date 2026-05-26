using Microsoft.AspNetCore.Mvc;
using GestionMascotas.Models;

namespace GestionMascotas.Controllers
{
    public class MascotasController : Controller
    {
        private static List<Mascota> mascotas = new List<Mascota>();

        public IActionResult Index()
        {
            return View(mascotas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mascota mascota)
        {
            mascotas.Add(mascota);

            return RedirectToAction("Index");
        }
    }
}