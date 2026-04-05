package ejercicio26;


public class asiento {
    private int fila;
    private int columna;
    private boolean reservado;

    public asiento(int fila, int columna) {
        this.fila = fila;
        this.columna = columna;
        this.reservado = false;
    }

    public void reservar() {
        reservado = true;
    }

    public void liberar() {
        reservado = false;
    }

    public boolean isReservado() {
        return reservado;
    }

    public String mostrar() {
        return reservado ? "[X]" : "[ ]";
    }

}