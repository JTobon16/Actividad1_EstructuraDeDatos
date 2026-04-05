using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.ejercicio26
{
    // aqui use struct dentro de la clase usando el Pos 
    public class Asiento
    {
        public Posicion Pos { get; set; }

        //guarda si esta ocupado
        public bool Reservado { get; set; }

        public Asiento(int fila, int columna)
        {   
            //este es el constructor
            Pos = new Posicion(fila, columna);
            Reservado = false;
        }
        // los metodos 
        public void Reservar()
        {
            Reservado = true;
        }

        public void Liberar()
        {
            Reservado = false;
        }

        public string Mostrar()
        {
            return Reservado ? "[X]" : "[ ]";
        }
    }
}
