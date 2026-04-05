using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.ejercicio26
{
    public class Sala
    {
        //aqui a diferencia de java se usa la matriz de objeto
        private Asiento[,] asientos;

        public Sala(int filas, int columnas)
        {
            asientos = new Asiento[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    asientos[i, j] = new Asiento(i, j);
                }
            }
        }
        public void Mostrar()
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    Console.Write(asientos[i, j].Mostrar());
                }
                Console.WriteLine();
            }
        }
        public void Reservar(int f, int c)
        {
            asientos[f, c].Reservado = true;
        }
        public void Liberar(int f, int c)
        {
            asientos[f, c].Reservado = false;
        }

    }
}
