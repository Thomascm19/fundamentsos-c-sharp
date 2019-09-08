using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platzi01.Entidades
{
    public class Alumnos
    {
        public string Nombre {get; set;}        
        public string Direccion { get; set; }
        public string Codigo { get; private set; }

        public Alumnos() => Codigo = Guid.NewGuid().ToString();
        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}
