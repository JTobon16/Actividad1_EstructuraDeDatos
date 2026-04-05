package ejercicio26;


public class asiento {
    //aqui defini el objeto del ejercicio, aqui no use matrices sino directamente un objeto dentro
    private int fila;
    private int columna;
    private boolean reservado;
    //hice el contructor de nuestro objeto
    public asiento(int fila, int columna) {
        this.fila = fila;
        this.columna = columna;
        this.reservado = false;
    }
    //cree mis dos metodos necesarios, el reservar y liberar
    public void reservar() {
        reservado = true;
    }

    public void liberar() {
        reservado = false;
    }

    public boolean isReservado() {
        return reservado;
    }
    //aqui nuestro mostrar, la parte visual al ejecutar
    public String mostrar() {
        return reservado ? "[X]" : "[ ]";
    }

}