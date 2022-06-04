/*Esta es la clase de la cuadrícula por la que se mueven los bloques*/
namespace DokiDokiTetrisClub2
{
    public class Grid
    {
        private readonly int[,] GameGrid;
        public int Filas { get; }
        public int Columnas { get; }

        public int this[int filas, int columas]
        {
            get
            {
                return GameGrid[filas, columas];
            }
            set
            {
                GameGrid[filas, columas] = value;
            }
        }

        public Grid(int filas, int columas)
        {
            this.Filas = filas;
            this.Columnas = columas;
            GameGrid = new int[filas, columas];
        }

        public bool DentroGrid(int fila, int columna)
        {
            if (fila >= 0 && fila < Filas && columna >= 0 && columna < Columnas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EstaVacio(int fila, int columna)
        {
            if (DentroGrid(fila, columna) == true && GameGrid[fila, columna] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FilaLlena(int fila)
        {
            for (int columna = 0; columna < Columnas; columna++)
            {
                if (GameGrid[fila, columna] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool FilaVacia(int fila)
        {
            for (int columna = 0; columna < Columnas; columna++)
            {
                if (GameGrid[fila, columna] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void BorrarFila(int fila)
        {
            for (int columna = 0; columna < Columnas; columna++)
            {
                GameGrid[fila, columna] = 0;
            }
        }

        private void BajarFilas(int fila, int Numfilas)
        {
            for (int columna = 0; columna < Columnas; columna++)
            {
                GameGrid[fila + Numfilas, columna] = GameGrid[fila, columna];
                GameGrid[fila, columna] = 0;
            }
        }

        public int BorrarLineasLLenas()
        {
            int Borradas = 0;

            for (int fila = Filas - 1; fila >= 0; fila--)
            {
                if (FilaLlena(fila) == true)
                {
                    BorrarFila(fila);
                    Borradas++;
                }
                else if (Borradas > 0)
                {
                    BajarFilas(fila, Borradas);
                }
            }

            return Borradas;
        }
    }
}
