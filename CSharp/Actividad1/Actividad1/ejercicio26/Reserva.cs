using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.ejercicio26
{
    //creo el objeto simple, al ser record es inmutable, es equivalente al dataclass en python
    public record Reserva(int Fila, int Columna);
}
