using Platzi01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi01.Engine
{
    public class UniversityEngine
    {
        public University Universidad { get; set; }
        public void Inicio()
        {
            Universidad = new University("Universidad de caldas", 1957, "Colombia",TypeDayTime.Mañana, TypesUniversity.Publica);
            GenerarCursos();
            GenerarMateria();
        }

        private void GenerarMateria()
        {
            foreach (var m in Universidad.Cursos)
            {
                var listaMaterias = new List<Materia>(){
                            new Materia{Nombre = "Matemáticas", NombreInstructor = "Fabio"},
                            new Materia{Nombre = "Educación Física", NombreInstructor = "Carlos"},
                            new Materia{Nombre = "Castellano", NombreInstructor = "Edwin"},
                            new Materia{Nombre = "Ciencias Naturales", NombreInstructor = "Mauricio"}
                };
                m.Materia = listaMaterias;
            }
        }
        private void GenerarCursos()
        {
            Universidad.Cursos = new List<Curso>(){
                 new Curso(){Nombre = "Programacion", Duracion = "3 Semanas", Jornada = TypeDayTime.Mañana},
                 new Curso(){Nombre = "Matematicas", Duracion = "1 Semanas", Jornada = TypeDayTime.Noche},
                 new Curso(){Nombre = "Bases de datos", Duracion = "2 Semanas", Jornada = TypeDayTime.Tarde}
            };
            Random numeroR = new Random();
            foreach(var r in Universidad.Cursos)
            {
                int cantRamdom = numeroR.Next(5, 20);
                r.Alumno = GenerarAlumnos(cantRamdom);
            }
        }
        public List<Alumnos> GenerarAlumnos(int cantidad)
        {
            
            string[] nombre = { "Thomas", "Carlos", "Andres", "Diana", "Manuela", "Isabel", "Victoria" };
            string[] apellido = { "Caycedo", "Martinez", "Valencia", "Lopez", "Castaño", "Osorio", "Rojas" };
            string[] direccion = { "Cr 17A # 4b-48", "Cr 1A # 457-32", "AV 88c # 12-43", "Cl 88h # 11-11", "Mz 10 # 33-22", "Cl 118A # 54-11", "AV 55z # 34-12" };
            var nombreCompleto = from n1 in nombre
                                 from n2 in apellido
                                 from d1 in direccion
                                 select new Alumnos { Nombre = $"{n1 } {n2}", Direccion = $"{d1}" };
            return nombreCompleto.OrderBy((al) => al.Codigo).Take(cantidad).ToList();
        }
    }
}