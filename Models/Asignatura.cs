using System;
using System.Collections.Generic;

namespace MvcProject.Models
{
    public class Asignatura:ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        List<Evaluación> Evaluaciones {get; set;}
    }
}