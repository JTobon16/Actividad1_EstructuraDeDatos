package objetos;

public class estudiante {

    private String nombre;
    private int edad;
    private double promedio;

    // el constructor
    public estudiante(String nombre, int edad, double promedio) {

        this.nombre = nombre;
        this.edad = edad;
        this.promedio = promedio;
    }

    //metodo que muestre la info
    public void mostrarInfo(){

        System.out.println("Nombre: " + nombre +", Edad: " + edad+ ", Promedio "+ promedio);
    }

    //setter para que cambie el promedio

    public void setpromedio(double nuevoPromedio) {
        this.promedio = nuevoPromedio;
    }

}
