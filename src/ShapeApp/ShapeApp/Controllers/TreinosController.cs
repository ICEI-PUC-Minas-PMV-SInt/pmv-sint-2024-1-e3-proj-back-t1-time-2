using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    public class TreinosController : Controller
    {
        private readonly AppDbContext _context;
        public TreinosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Treinos.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Treino treino)
        {
            if (ModelState.IsValid)
            {
                _context.Treinos.Add(treino);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(treino);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) 
                return NotFound();
            var dados = await _context.Treinos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Treino treino)
        {
            if (id != treino.Id)
                return NotFound(id);

            if (ModelState.IsValid)
            {
               _context.Treinos.Update(treino);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id) 
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Treinos.FindAsync(id);

            if(dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Treinos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Treinos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Treinos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}