using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    [Authorize]
    public class ExerciciosController : Controller
    {
       private readonly AppDbContext _context;
        public ExerciciosController(AppDbContext context)
        {
        _context = context;
        }
        public async Task<IActionResult> Index() 
        {
            var dados = await _context.Exercicios
                .ToListAsync();

            return View(dados);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Exercicio exercicio)
        {
           if (ModelState.IsValid)
            {
                _context.Exercicios.Add(exercicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(exercicio);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Exercicios.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Exercicio exercicio)
        {
            if (id != exercicio.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Exercicios.Update(exercicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
           if (id == null)
                return NotFound();

            var dados = await _context.Exercicios.FindAsync(id);

            if (dados == null)
                return NotFound();
            
            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Exercicios.FindAsync(id);

            if (dados == null)
                return NotFound();  

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Exercicios.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Exercicios.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }

}
