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
            return View(_context.Alumnos.ToList());
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

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                var curso = _context.Cursos.FirstOrDefault();
                alumno.Id = Guid.NewGuid().ToString();
                alumno.CursoId = curso.Id;
                _context.Alumnos.Add(alumno);
                _context.SaveChanges();
                return RedirectToAction("Index", new { alumnoId = alumno.Id });
            }
            else
            {
                return View(alumno);
            }

        }
        public IActionResult Update(string alumnoId)
        {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {
                var alumno = _context.Alumnos.Where(a => a.Id == alumnoId).FirstOrDefault();
                return View(alumno);
            }
            else
            {
                return View("MultiAlumno");
            }
        }
        [HttpPost]
        public IActionResult Update(Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                var alumnoUpdate = _context.Alumnos.Where(a => a.Id == alumno.Id).FirstOrDefault();
                alumnoUpdate.Nombre = alumno.Nombre;

                _context.SaveChanges();
                return RedirectToAction("Index", new { alumnoId = alumno.Id });
            }
            else
            {
                return View(alumno);
            }

        }
        public IActionResult Delete(string alumnoId)
        {
            if (!string.IsNullOrWhiteSpace(alumnoId))
            {
                var alumno = _context.Alumnos.Where(c => c.Id == alumnoId).FirstOrDefault();
                _context.Alumnos.Remove(alumno);
                _context.SaveChanges();
                return RedirectToAction("MultiAlumno");
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }




    }
}