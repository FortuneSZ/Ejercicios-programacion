// Esta clase se utiliza para gestionar la posición de los bloques
namespace DokiDokiTetrisClub
{
    public class Posicion
    {
        public int Fila { get; set; }
        public int Columna { get; set; }

        public Posicion(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }
    }
}
