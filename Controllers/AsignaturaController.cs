using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;

namespace MvcProject.Controllers
{
    public class AsignaturaController : Controller
    {
        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
        public IActionResult MultiAsignatura()
        {
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Asignaturas.ToList());
        }
        [Route("Asignatura/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = from asig in _context.Asignaturas
                                 where asig.Id == asignaturaId
                                 select asig;
                return View(asignatura.SingleOrDefault());
            }
            else
            {
                return View("MultiAsignatura", _context.Asignaturas.ToList());
            }
        }
        public IActionResult Create(){
            return View();
        }
                [HttpPost]
        public IActionResult Create(Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                var curso = _context.Cursos.FirstOrDefault();
                asignatura.Id = Guid.NewGuid().ToString();
                asignatura.CursoId = curso.Id;
                _context.Asignaturas.Add(asignatura);
                _context.SaveChanges();
                return RedirectToAction("Index", new { asignaturaId = asignatura.Id });
            }
            else
            {
                return View(asignatura);
            }

        }
        public IActionResult Update(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = _context.Asignaturas.Where(a => a.Id == asignaturaId).FirstOrDefault();
                return View(asignatura);
            }
            else
            {
                return View("MultiAsignatura");
            }
        }
        [HttpPost]
        public IActionResult Update(Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                var asignaturaUpdate = _context.Asignaturas.Where(e => e.Id == asignatura.Id).FirstOrDefault();
                asignaturaUpdate.Nombre = asignatura.Nombre;

                _context.SaveChanges();
                return RedirectToAction("Index", new { asignaturaId = asignatura.Id });
            }
            else
            {
                return View(asignatura);
            }

        }
        public IActionResult Delete(string asignaturaId)
        {
            if (!string.IsNullOrWhiteSpace(asignaturaId))
            {
                var asignatura = _context.Asignaturas.Where(c => c.Id == asignaturaId).FirstOrDefault();
                _context.Asignaturas.Remove(asignatura);
                _context.SaveChanges();
                return RedirectToAction("MultiAsignatura");
            }
            else
            {
                return View("MultiAsignatura", _context.Cursos);
            }
        }
    }
}