using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi01.Entidades
{
    public class Parciales
    {
        public string Nombre {get; set;}
        public float Nota { get; set; }
        public List<Materia> Materia { get; set; }
        public List<Alumnos> Alumno { get; set; }
    }
}
