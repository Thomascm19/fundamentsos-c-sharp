using System;
using System.Collections.Generic;

namespace Platzi01.Entidades
{
    public class University
    {
        public string Nit { get; private set; } = Guid.NewGuid().ToString();
        public string Nombre { get; set; }
        public int AñoFundacion { get; set; }
        public string Pais { get; set; }
        public TypesUniversity TipoUniversidad { get; set; }
        public TypeDayTime Jornada { get; set;}
        public List<Materia> Materias { get; set; }
        public List<Curso> Cursos { get; set; }
        public University(string nombre, int fechaFundacion, string pais, TypeDayTime mañana, TypesUniversity publica) => (this.Nombre, this.AñoFundacion, this.Pais) = (nombre, fechaFundacion, pais);
        public override string ToString()
        {
            return $"Nombre: {Nombre} \nFecha de fundacion: {AñoFundacion} \nPais:{Pais}";
        }
    }
}
