package objetos;

public class Main {
    public static void main(String[] args) {
        estudiante e1 = new estudiante("Jonathan", 26, 4.6);
        estudiante e2 = new estudiante("Jinx", 21, 3.5);
        estudiante e3 = new estudiante("Jose", 19, 4.0);

        estudiante[] lista = {e1, e2, e3};

        System.out.println(" Listado de Estudiantes: ");
        for (estudiante e : lista) {
            e.mostrarInfo();
        }

        // cambiamos promedio de un estudiante (e2)
        e2.setpromedio(4.1);

        System.out.println("\n Despues de la modificacion de Jinx  ");
        for (estudiante e : lista) {
            e.mostrarInfo();
        }
    }
}
