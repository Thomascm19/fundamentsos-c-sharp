using System;

namespace Platzi01.Entidades
{
    public class Materia
    {
        public string Codigo { get; private set; }
        public string Nombre { get; set; }
        public string NombreInstructor { get; set; }
        public Materia() => Codigo = Guid.NewGuid().ToString();
    }
}
