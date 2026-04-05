using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.ejercicio26
{
    class Program
    {
        static void Main()
        {
            Sala sala = new Sala(5, 5);

            Console.WriteLine("Sala de Cine");
            sala.Mostrar();

            Console.WriteLine("\nReservando asiento (3,3)\n");
            sala.Reservar(2, 2);

            sala.Mostrar();

            Console.WriteLine("\nLiberando asiento (3,3)\n");
            sala.Liberar(2, 2);

            sala.Mostrar();
        }
    }
}
