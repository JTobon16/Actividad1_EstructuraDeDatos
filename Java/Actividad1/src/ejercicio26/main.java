package ejercicio26;

public class main {
    public static void main(String[] args) {

        sala sala = new sala(5, 5);

        System.out.println("Sala de Cine");

        sala.mostrarSala();

        System.out.println("\nReservando asiento (3,3)\n");
        sala.reservar(2, 2);

        sala.mostrarSala();

        System.out.println("\nLiberando asiento (3,3)\n");
        sala.liberar(2, 2);

        sala.mostrarSala();
    }
}