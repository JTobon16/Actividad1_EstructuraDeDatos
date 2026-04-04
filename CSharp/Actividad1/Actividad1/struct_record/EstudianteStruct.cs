using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.struct_record
{
    public struct EstudianteStruct
    {
        public string Nombre;
        public int Edad;
        public double Promedio;

        public EstudianteStruct(string nombre, int edad, double promedio)
        {
            Nombre = nombre;
            Edad = edad;
            Promedio = promedio;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Promedio: {Promedio}");
        }
    }

    class ProgramStruct
    {
        static void Main(string[] args)
        {
            var s1 = new EstudianteStruct("Ana", 20, 4.5);
            var s2 = new EstudianteStruct("Luis", 22, 3.8);
            var s3 = new EstudianteStruct("Carla", 19, 4.2);

            var lista = new EstudianteStruct[] { s1, s2, s3 };

            Console.WriteLine("=== Información inicial (struct) ===");
            foreach (var e in lista)
                e.Mostrar();

            // Modificación
            lista[1].Promedio = 4.1;

            Console.WriteLine("\n=== Después de modificar promedio de Luis ===");
            foreach (var e in lista)
                e.Mostrar();
        }
    }
}
