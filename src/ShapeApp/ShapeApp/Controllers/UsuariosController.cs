using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShapeApp.Models;

namespace ShapeApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var listaUsuarios = await _context.Usuarios.ToListAsync();

            var ListaPerfilShape = await _context.PerfilShape.ToListAsync();

            List<DadosCadastro> listaDadosCadastro = new List<DadosCadastro>();

            foreach (Usuario usuario in listaUsuarios)
            {
                listaDadosCadastro.Add(
                    new DadosCadastro
                    {
                        Usuario = usuario,
                        PerfilShape = ListaPerfilShape.Find(x => x.UsuarioId == usuario.Id)
                    }
                );
            }

            return View(listaDadosCadastro);
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            var dados = await _context.Usuarios
                .FindAsync(usuario.Id);

            if (dados == null)
            {
                ViewBag.Usuario = "Usuario e/ou senha invalidos!";
                return View();
            }

            bool senhaOK = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOK)
            {
                var claims = new List<Claim>
            {
            new Claim(ClaimTypes.Name, dados.Nome),
            new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString()),
            new Claim(ClaimTypes.Role, dados.Perfil.ToString())
            };
                var usuarioIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };
                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");


            }
            else
            {
                ViewBag.Usuario = "Usuario e/ou senha invalidos!";
            }
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login", "Usuarios");

        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }

            var perfilShape = await _context.PerfilShape
                .FirstOrDefaultAsync(m => m.UsuarioId == id);

            if (perfilShape == null)
            {
                return NotFound();
            }

            return View(new DadosCadastro { Usuario = usuario, PerfilShape = perfilShape });
        }

        // GET: Usuarios/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Usuario,PerfilShape")] DadosCadastro dadosCadastro)
        {
            if (ModelState.IsValid)
            {
                dadosCadastro.Usuario.Senha = BCrypt.Net.BCrypt.HashPassword(dadosCadastro.Usuario.Senha);
                _context.Add(dadosCadastro.Usuario);
                await _context.SaveChangesAsync();

                dadosCadastro.PerfilShape.UsuarioId = dadosCadastro.Usuario.Id;
                _context.Add(dadosCadastro.PerfilShape);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {

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

        // POST: Perfil
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Usuario,PerfilShape")] DadosCadastro dadosCadastro)
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
                return RedirectToAction(nameof(Index));
            }

            return View(dadosCadastro);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }

            var perfilShape = await _context.PerfilShape
                .FirstOrDefaultAsync(m => m.IdPerfil == id);

            if (perfilShape == null)
            {
                return NotFound();
            }

            return View(new DadosCadastro { Usuario = usuario, PerfilShape = perfilShape });
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
            await _context.SaveChangesAsync();

            var perfilShape = await _context.PerfilShape.FindAsync(id);
            if (perfilShape != null)
            {
                _context.PerfilShape.Remove(perfilShape);
            }
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
