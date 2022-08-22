﻿using Administrador.Models;
using ControlAsistencia_.Models;
using DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ControlAsistenciaDBContext _context;
        public HomeController(ILogger<HomeController> logger, ControlAsistenciaDBContext context) { 
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Asistencias()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DetallesEmpleado(string idEmpleado)
        {
            return Content(" a"+idEmpleado);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
