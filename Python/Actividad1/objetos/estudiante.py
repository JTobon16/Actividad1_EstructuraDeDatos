
# aqui creamos la clase tradicional
class Estudiante:
    def __init__(self, nombre, edad, promedio):
        self.nombre = nombre
        self.edad = edad
        self.promedio = promedio

    def mostrar_info(self):
        print(f"nombre:{self.nombre}, edad:{self.edad}, promedio:{self.promedio}")

    def set_promedio(self,nuevo_promedio):
        self.promedio = nuevo_promedio

# aqui estara la ejecucion del programa
if __name__ == "__main__":
    r1 = Estudiante("Jonathan", 20, 4.5)
    r2 = Estudiante("Jinx", 22, 3.8)
    r3 = Estudiante("Carla", 19, 4.2)

    lista = [r1, r2, r3]

    print("Informacion inicial de la clase")
    for e in lista:
          e.mostrar_info()

#aqui hicimos la modificacion del promedio
    r2.set_promedio(5)
    print("\n Despues de la modificacion de Jinx")
    for e in lista:
        e.mostrar_info()



