using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class AlumnoController : Controller
    {
        public EscuelaContext _context { get; set; }
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
        public IActionResult MultiAlumno()
        {
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Alumnos);
        }
        [Route("Alumno/Index")]
        [Route("Alumno/Index/{alumnoId}")]
        public IActionResult Index(string alumnoId)
        {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {
                var alumno = from alum in _context.Alumnos
                             where alum.Id == alumnoId
                             select alum;
                return View(alumno.FirstOrDefault());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }
    }
}