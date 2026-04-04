from dataclasses import dataclass

@dataclass

class Estudiante:
    nombre: str
    edad: int
    promedio: float

    # === Bloque de ejecución propio ===
if __name__ == "__main__":
        r1 = Estudiante("Jonathan", 20, 4.5)
        r2 = Estudiante("Jinx", 22, 3.8)
        r3 = Estudiante("Carla", 19, 4.2)
        lista_r = [r1, r2, r3]

        print(" Información inicial (record) ")
        for e in lista_r:
            print(e)

        # Modificación
        r2.promedio = 4.1
        print("\n Despues de modificar promedio de Jinx ")
        for e in lista_r:
            print(e)