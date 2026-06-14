using Microsoft.AspNetCore.Mvc;
using GestionMascotas.Data;
using GestionMascotas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionMascotas.Controllers
{
    public class MascotasController : Controller
    {
        private readonly AppDbContext _context;

        public MascotasController(AppDbContext context)
        {
            _context = context;
        }

        // LISTAR
        public async Task<IActionResult> Index()
        {
            var mascotas = await _context.Mascotas.ToListAsync();
            return View(mascotas);
        }

        // CREATE (GET)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(mascota);
        }
    }
}