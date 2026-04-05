using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.ejercicio26
{
    public struct Posicion
    {
        public int Fila;
        public int Columna;

        public Posicion(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }
    }
    //se usa struct porque es mas ligero al guardar datos
}
