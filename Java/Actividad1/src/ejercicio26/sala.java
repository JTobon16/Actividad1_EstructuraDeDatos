package ejercicio26;

public class sala {
    private asiento[][] asientos;

    public sala(int filas, int columnas) {
        asientos = new asiento[filas][columnas];

        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                asientos[i][j] = new asiento(i, j);
            }
        }
    }

    public void mostrarSala() {
        for (asiento[] fila : asientos) {
            for (asiento a : fila) {
                System.out.print(a.mostrar());
            }
            System.out.println();
        }
    }

    public void reservar(int fila, int columna) {
        asientos[fila][columna].reservar();
    }

    public void liberar(int fila, int columna) {
        asientos[fila][columna].liberar();
    }
}

