using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models
{
    public class Curso:ObjetoEscuelaBase
    {
        [Required(ErrorMessage = "Seleccione una jornada")]
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }
        [Display(Prompt="Dirección correspondencia", Name="Dirección")]
        [Required(ErrorMessage = "Se requiere incluir una dirección")]
        [MinLength(10, ErrorMessage = "La longitud requerida de la dirección es 10")]
        public string Dirección { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
        [Required(ErrorMessage = "El nombre del curso es requerido")]
        [StringLength(50)]
        public override string Nombre { get; set; }

    }
}