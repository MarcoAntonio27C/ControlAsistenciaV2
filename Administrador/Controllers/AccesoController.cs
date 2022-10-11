using DBContext;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControlAsistencia_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Controllers
{
    public class AccesoController : Controller
    {
        private readonly ControlAsistenciaDBContext _context;

        public AccesoController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(string usuario, string password)
        {
            var _usuario = await _context.Usuario.Where(x => x.NombreUsuario.Equals(usuario) && x.Password.Equals(password) && x.Activo.Equals(true)).FirstOrDefaultAsync();
            if(_usuario != null)
            {
                var claims = new List<Claim>
                {
                    
                    new Claim(ClaimTypes.Name, _usuario.NombreUsuario),
                    new Claim(ClaimTypes.Surname, _usuario.IdUnidadAdministrativa),
                    new Claim(ClaimTypes.Role, _usuario.IdRol)
                };

                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index","Home");
            }
            return View("Index");
        }

        public async Task<IActionResult> SalirAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Acceso");
        }
    }
}
