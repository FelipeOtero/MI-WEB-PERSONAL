using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MI_WEB_PERSONAL.Models;

namespace MI_WEB_PERSONAL.Controllers;

  public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            return View();
        }

        public IActionResult Cursos()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            ViewBag.Cursos = Datos.Getcursos();
            return View();
        }

        public IActionResult Idiomas()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            ViewBag.Idiomas = Datos.GetIdiomas();
            return View();
        }

        public IActionResult Proyectos()
        {
            ViewBag.DatosPersonales = Datos.GetDatosPersonales();
            ViewBag.Proyectos = Datos.GetProyectos();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { });
        }
    }
