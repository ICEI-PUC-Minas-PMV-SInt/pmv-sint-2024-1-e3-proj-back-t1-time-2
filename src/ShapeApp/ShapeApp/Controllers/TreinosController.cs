using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    [Authorize]
    public class TreinosController : Controller
    {
        private readonly AppDbContext _context;
        public TreinosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Treinos
                .Include(treino => treino.Exercicios)
                .ToListAsync();

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
                var exercicios = await _context.Exercicios.ToListAsync();

                var quantidade = new Random().Next(Math.Min(4, exercicios.Count), exercicios.Count);

                for (int i = 0; i < quantidade; i++)
                {
                    var exercicio = exercicios[new Random().Next(0, exercicios.Count)];
                    treino.Exercicios.Add(exercicio);
                }

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

            if (dados == null)
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

        public async Task<IActionResult> Exercicios(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Treinos.Include(t => t.Exercicios).FirstOrDefaultAsync(t => t.Id == id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> RemoverExercicio(int id, int exericioid)
        {
            // Busca o Treino com o ID
            var dados = await _context.Treinos.Include(t => t.Exercicios).FirstOrDefaultAsync(t => t.Id == id);

            // Busca o Exericio dentro do treino ID cujo exercicio seja o exericicioid
            var exericio = dados.Exercicios.FirstOrDefault(e => e.Id == exericioid);

            // remove o exercicio da lista para aquele treino ID
            dados.Exercicios.Remove(exericio);

            await _context.SaveChangesAsync();

            return RedirectToAction("Exercicios", new { id = id });
        }

        public async Task<IActionResult> AddExercicio(int? id)
        {
            var dados = await _context.Treinos.Include(t => t.Exercicios).FirstOrDefaultAsync(t => t.Id == id);

            // Lista todos os exercícios
            var exercicios = await _context.Exercicios.ToListAsync();

            ViewBag.Exercicios = exercicios;

            return View(dados);
        }

        public async Task<IActionResult> VincularExercicio(int id, int exercicioId)
        {

            var exercicio = await _context.Exercicios.FindAsync(exercicioId);

            var treino = await _context.Treinos.Include(t => t.Exercicios).FirstOrDefaultAsync(t => t.Id == id);

            treino.Exercicios.Add(exercicio);

            await _context.SaveChangesAsync();

            return RedirectToAction("Exercicios", new { id = id });
        }
    }
}