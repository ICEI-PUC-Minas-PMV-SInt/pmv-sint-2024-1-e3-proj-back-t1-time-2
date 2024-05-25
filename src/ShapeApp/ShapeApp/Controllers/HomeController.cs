using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var dados = _context.MensagensHome.ToList();

            Random random = new Random();
            var numAleatorio = random.Next(0, dados.Count);

            return View(dados.IsNullOrEmpty() ? new MensagensHome() : dados[numAleatorio]);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MensagensHome mensagensHome)
        {
            if(ModelState.IsValid)
            {
                _context.MensagensHome.Add(mensagensHome);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mensagensHome);
        }

        public IActionResult EdicaoMensagens()
        {
            var dados = _context.MensagensHome.ToList();
            return View(dados);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var dados = _context.MensagensHome.Find(id);
            if(dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost]
        public IActionResult Edit(int id, MensagensHome mensagensHome)
        {
            if(id != mensagensHome.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.MensagensHome.Update(mensagensHome);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = _context.MensagensHome.Find(id);
            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = _context.MensagensHome.Find(id);
            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dados = _context.MensagensHome.Find(id);
            if (dados == null)
            {
                return NotFound();
            }

            _context.MensagensHome.Remove(dados);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
