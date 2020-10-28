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

        [Route("Curso/{cursoId}")]
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
            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();
                curso.Id = Guid.NewGuid().ToString();
                curso.EscuelaId = escuela.Id;
                _context.Cursos.Add(curso);
                _context.SaveChanges();
                return RedirectToAction("Index", new { cursoId = curso.Id });
            }
            else
            {
                return View(curso);
            }

        }
        public IActionResult Update(string cursoId)
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
        [HttpPost]
        public IActionResult Update(Curso curso)
        {
            if (ModelState.IsValid)
            {
                var cursoUpdate = _context.Cursos.Where(e => e.Id == curso.Id).FirstOrDefault();
                cursoUpdate.Dirección = curso.Dirección;
                cursoUpdate.Nombre = curso.Nombre;
                cursoUpdate.Jornada = curso.Jornada;
                _context.SaveChanges();
                return RedirectToAction("Index", new { CursoId = curso.Id });
            }
            else
            {
                return View(curso);
            }

        }
        public IActionResult Delete(string cursoId)
        {
            if (!string.IsNullOrWhiteSpace(cursoId))
            {
                var curso = _context.Cursos.Where(c => c.Id == cursoId).FirstOrDefault();
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
                return RedirectToAction("MultiCurso");
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }
    }
}