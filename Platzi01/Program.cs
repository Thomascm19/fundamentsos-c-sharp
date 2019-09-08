using Platzi01.Engine;
using Platzi01.Entidades;
using System;

namespace Platzi01
{
    class Program
    {
        static void Main(string[] args)
        {
            var UniversityEngine = new UniversityEngine();
            UniversityEngine.Inicio();
            ImpimirCursosEscuela(UniversityEngine.Universidad);
            Console.ReadKey();
        }
        private static void ImpimirCursosEscuela(University universidad)
        {
            if (universidad?.Cursos != null)
            {
                foreach (var curso in universidad.Cursos)
                {
                    Console.WriteLine($"Nombre: {curso.Nombre  }, Id: {curso.Codigo}");
                }
            }
        }
    }
}
