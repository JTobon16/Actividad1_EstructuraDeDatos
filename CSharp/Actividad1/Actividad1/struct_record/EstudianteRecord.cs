using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.struct_record
{
    // === Record ===
    public record EstudianteRecord(string Nombre, int Edad, double Promedio);

    // Bloque principal para ejecutar este record
    class ProgramRecord
    {
        static void Main(string[] args)
        {
            // Inicialización
            var r1 = new EstudianteRecord("Ana", 20, 4.5);
            var r2 = new EstudianteRecord("Luis", 22, 3.8);
            var r3 = new EstudianteRecord("Carla", 19, 4.2);

            var listaR = new List<EstudianteRecord> { r1, r2, r3 };

            Console.WriteLine("=== Información inicial (record) ===");
            foreach (var e in listaR)
                Console.WriteLine(e);

            // Modificación: con records se crea un nuevo objeto
            r2 = r2 with { Promedio = 4.1 };
            listaR[1] = r2;

            Console.WriteLine("\n=== Después de modificar promedio de Luis ===");
            foreach (var e in listaR)
                Console.WriteLine(e);
        }
    }
}
