using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class CursoController : Controller
    {
        public EscuelaContext _context { get; set; }
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

        public IActionResult MultiCurso()
        {
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Cursos);
        }
        [Route("Curso/Index")]
        [Route("Curso/Index/{cursoId}")]
        public IActionResult Index(string cursoId)
        {
            if (!string.IsNullOrWhiteSpace(cursoId))
            {
                var curso = from cur in _context.Cursos
                             where cur.Id == cursoId
                             select cur;
                return View(curso.FirstOrDefault());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Curso curso)
        {
            var escuela = _context.Escuelas.FirstOrDefault();
            curso.EscuelaId = escuela.Id;
            _context.Cursos.Add(curso);
            _context.SaveChanges();
            return View();
        }
    }
}