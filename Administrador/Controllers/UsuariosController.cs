using ControlAsistencia_.Models;
using DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ControlAsistenciaDBContext _context;
        // GET: UsuariosController

        public UsuariosController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> InicioAsync()
        {
            var usuario = await _context.Usuario.ToListAsync();
            var roles = await _context.Roles.ToListAsync();
            var unidades = await _context.UnidadAdministrativa.ToListAsync();
            ViewData["usuarios"] = usuario;
            ViewData["roles"] = roles;
            ViewData["unidades"] = unidades;
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Agregar()
        {
            var unidades = await _context.UnidadAdministrativa.ToListAsync();
            ViewData["unidades"] = unidades;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Agregar(IFormCollection form)
        {
            Usuario usuario = new Usuario();
            usuario.Id = new Guid();
            usuario.Administrador = form["administrador"];
            usuario.NombreUsuario = form["nombreUsuario"];
            usuario.Password = "ControlFGE2022**";
            usuario.IdRol = form["rol"];
            usuario.IdUnidadAdministrativa = form["unidadAdministrativa"];

            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return View("Agregar");
        }

    }
}
