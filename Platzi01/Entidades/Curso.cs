using System;
using System.Collections.Generic;

namespace Platzi01.Entidades
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string Codigo { get; private set; }
        public string Duracion { get; set; }
        public TypeDayTime Jornada { get; set; }
        public List<Materia> Materia { get; set; }
        public List<Alumnos> Alumno { get; set; }
        public Curso() => Codigo = Guid.NewGuid().ToString();
    }
}
