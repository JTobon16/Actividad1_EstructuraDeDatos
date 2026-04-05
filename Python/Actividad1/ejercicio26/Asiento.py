from dataclasses import dataclass

@dataclass
class Asiento:
    fila: int
    columna: int
    reservado: bool = False

    def reservar(self):
        self.reservado = True

    def liberar(self):
        self.reservado = False

    def mostrar(self):
        return "[X]" if self.reservado else "[ ]"


class Sala:
    def __init__(self, filas, columnas):
        self.asientos = [[Asiento(i, j) for j in range(columnas)] for i in range(filas)]

    def mostrar(self):
        for fila in self.asientos:
            print("".join(a.mostrar() for a in fila))

    def reservar(self, f, c):
        self.asientos[f][c].reservar()

    def liberar(self, f, c):
        self.asientos[f][c].liberar()


# MAIN
sala = Sala(5, 5)

print("Sala de Cine")
sala.mostrar()

print("\nReservando (2,2)\n")
sala.reservar(1, 1)
sala.mostrar()

print("\nLiberando (2,2)\n")
sala.liberar(1, 1)
sala.mostrar()

