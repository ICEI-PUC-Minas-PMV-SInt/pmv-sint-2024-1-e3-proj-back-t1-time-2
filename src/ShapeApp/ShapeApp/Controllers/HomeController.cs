using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.MensagensHome.ToListAsync();

            Random random = new Random();
            var numAleatorio = random.Next(0, dados.Count);

            return View(dados.IsNullOrEmpty() ? new MensagensHome() : dados[numAleatorio]);
        }

    }
}
