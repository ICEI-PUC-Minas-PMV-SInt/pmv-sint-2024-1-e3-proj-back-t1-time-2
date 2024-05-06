using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    public class ExerciciosController : Controller
    {
       private readonly AppDbContext _context;
        public ExerciciosController(AppDbContext context)
        {
        _context = context;
        }
        public async Task<IActionResult> Index() 
        {
            var dados = await _context.Exercicios.ToListAsync();

            return View(dados);
        }
    }

}
