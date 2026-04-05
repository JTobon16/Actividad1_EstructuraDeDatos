package ejercicio26;

public class sala {
    //aqui creo mi matris del objeto
    private asiento[][] asientos;
    //constructor, creo la matriz vacia
    public sala(int filas, int columnas) {
        asientos = new asiento[filas][columnas];

        //el respectivo recorrido de la matriz
        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                asientos[i][j] = new asiento(i, j);
            }
        }
    }
    // el mostrar sala, use el for each
    public void mostrarSala() {
        for (asiento[] fila : asientos) {
            for (asiento a : fila) {
                System.out.print(a.mostrar());
            }
            System.out.println();
        }
    }
    //el reservar y liberar, llamo los metodos creado en mi objeto
    public void reservar(int fila, int columna) {
        asientos[fila][columna].reservar();
    }

    public void liberar(int fila, int columna) {
        asientos[fila][columna].liberar();
    }
}

