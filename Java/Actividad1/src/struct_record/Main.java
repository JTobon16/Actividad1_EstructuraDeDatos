package struct_record;

public class Main {
    public static void main(String[] args) {

        // creamos los estudiantes
        estudiante e1 = new estudiante("Jonathan", 20, 4.5);
        estudiante e2 = new estudiante("Jinx", 22, 3.8);
        estudiante e3 = new estudiante("Andres", 19, 4.2);

        // aqui guardamos el arreglo
        estudiante[] estudiantes = {e1, e2, e3};

        // hacemos el recorrido con el for
        for (estudiante e : estudiantes) {
            System.out.println(
                    "Nombre: " + e.nombre() +
                            " Edad: " + e.edad() +
                            " Promedio: " + e.promedio()
            );
        }

        //hacemos la modificacion (record = inmutable)
        e2 = new estudiante("Ana", 22, 4.0);

        System.out.println("\nDespués de modificar:");
        System.out.println(e2);
    }
}