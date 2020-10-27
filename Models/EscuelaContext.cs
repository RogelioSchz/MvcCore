using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MvcProject.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var escuela = new Escuela()
            {
                AñoDeCreación = 2020,
                Nombre = "Universidad Veracruzana",
                Id = Guid.NewGuid().ToString(),
                Ciudad = "Veracruz",
                Pais = "México",
                Dirección = "Circuito Presidentes # 23",
                TipoEscuela = TiposEscuela.Secundaria
            };
            var cursos = CargarCursos(escuela);
            var asignaturas = CargarAsignaturas(cursos);
            var alumnos = CargarAlumnos(cursos);

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Curso>().HasData(cursos.ToArray());
            modelBuilder.Entity<Asignatura>().HasData(asignaturas.ToArray());
            modelBuilder.Entity<Alumno>().HasData(alumnos.ToArray());

        }

        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {
            List<Asignatura> listaCompleta = new List<Asignatura>();
            foreach (var curso in cursos)
            {
                var tmpList = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas",
                            Id = Guid.NewGuid().ToString(), CursoId= curso.Id} ,
                            new Asignatura{Nombre="Educación Física",
                            Id = Guid.NewGuid().ToString(), CursoId= curso.Id},
                            new Asignatura{Nombre="Castellano",
                            Id = Guid.NewGuid().ToString(), CursoId= curso.Id},
                            new Asignatura{Nombre="Ciencias Naturales",
                            Id = Guid.NewGuid().ToString(), CursoId= curso.Id}
                };
                listaCompleta.AddRange(tmpList);

            }
            return listaCompleta;
        }

        private static List<Curso> CargarCursos(Escuela escuela)
        {
            return new List<Curso>(){
                        new Curso(){Id = Guid.NewGuid().ToString(),
                        Nombre = "101",
                        Jornada = TiposJornada.Mañana,
                        EscuelaId = escuela.Id },
                        new Curso() {Id = Guid.NewGuid().ToString(), Nombre = "201", Jornada = TiposJornada.Mañana, EscuelaId = escuela.Id},
                        new Curso{Id = Guid.NewGuid().ToString(), Nombre = "301", Jornada = TiposJornada.Mañana, EscuelaId = escuela.Id},
                        new Curso(){Id = Guid.NewGuid().ToString(), Nombre = "401", Jornada = TiposJornada.Tarde, EscuelaId = escuela.Id },
                        new Curso() {Id = Guid.NewGuid().ToString(), Nombre = "501", Jornada = TiposJornada.Tarde, EscuelaId = escuela.Id},
            };
        }
        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(curso, cantRandom);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }
        private List<Alumno> GenerarAlumnosAlAzar(Curso curso, int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   CursoId = curso.Id,
                                   Nombre = $"{n1} {n2} {a1}"
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }
    }
}