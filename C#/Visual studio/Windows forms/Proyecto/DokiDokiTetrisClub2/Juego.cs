namespace DokiDokiTetrisClub2
{
    public class Juego
    {
        private Bloque BloqueActual;

        public Bloque VerBloqueActual
        {
            get
            {
                return BloqueActual;
            }
            private set
            {
                BloqueActual = value;
                BloqueActual.Reset();
            }
        }

        public Grid Grid { get; }
        public ColaBloques ColaBloques { get; }
        public bool FinJuego { get; private set; }

        public Juego()
        {
            Grid = new Grid(22, 10);
            ColaBloques = new ColaBloques();
            BloqueActual = ColaBloques.Actualizar();
        }

        private bool Encaja()
        {
            foreach (Posicion p in BloqueActual.PosicionCasillas())
            {
                if (!Grid.EstaVacio(p.Fila, p.Columna))
                {
                    return false;
                }
            }
            return true;
        }

        public void GirarBloqueH()
        {
            BloqueActual.RotarHorario();

            if (!Encaja())
            {
                BloqueActual.RotarAntiHorario();
            }
        }

        public void GirarBloqueAH()
        {
            BloqueActual.RotarAntiHorario();

            if (!Encaja())
            {
                BloqueActual.RotarHorario();
            }
        }

        public void MoverBloqueIz()
        {
            BloqueActual.Mover(0, -1);

            if (!Encaja())
            {
                BloqueActual.Mover(0, 1);
            }
        }

        public void MoverBloqueDer()
        {
            BloqueActual.Mover(0, 1);

            if (!Encaja())
            {
                BloqueActual.Mover(0, -1);
            }
        }


    }
}
