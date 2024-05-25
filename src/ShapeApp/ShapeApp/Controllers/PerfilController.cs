using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    [Authorize]
    public class PerfilController : Controller
    {
        private readonly AppDbContext _context;

        public PerfilController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Perfil
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                int? id = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                if (id == null || _context.Usuarios == null)
                {
                    return NotFound();
                }

                var usuario = await _context.Usuarios.FindAsync(id);
                if (usuario == null)
                {
                    return NotFound();
                }

                var perfilShape = await _context.PerfilShape.FindAsync(id);
                if (perfilShape == null)
                {
                    return NotFound();
                }

                var dadosCadastro = new DadosCadastro
                {
                    Usuario = usuario,
                    PerfilShape = perfilShape
                };

                return View(dadosCadastro);
            }
            else
            {
                return BadRequest();
            }
        }

        // POST: Perfil
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Usuario,PerfilShape")] DadosCadastro dadosCadastro)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dadosCadastro.Usuario.Senha = BCrypt.Net.BCrypt.HashPassword(dadosCadastro.Usuario.Senha);
                    _context.Usuarios.Update(dadosCadastro.Usuario);
                    await _context.SaveChangesAsync();

                    dadosCadastro.PerfilShape.IdPerfil = dadosCadastro.Usuario.Id;
                    dadosCadastro.PerfilShape.UsuarioId = dadosCadastro.Usuario.Id;
                    _context.PerfilShape.Update(dadosCadastro.PerfilShape);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(dadosCadastro.Usuario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/");
            }
            return View(dadosCadastro);
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }

    }
}
