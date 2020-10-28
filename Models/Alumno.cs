using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; }
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        [Required(ErrorMessage = "El nombre del alumno es requerido")]
        [StringLength(50)]
        public override string Nombre { get; set; }
    }
}