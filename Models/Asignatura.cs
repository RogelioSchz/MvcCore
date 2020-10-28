using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class Asignatura : ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        List<Evaluación> Evaluaciones { get; set; }
        [Required(ErrorMessage = "El nombre de la asinatura es requerido")]
        [StringLength(50)]
        public override string Nombre { get; set; }
    }
}