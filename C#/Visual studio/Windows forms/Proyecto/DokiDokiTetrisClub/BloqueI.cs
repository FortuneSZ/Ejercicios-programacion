namespace DokiDokiTetrisClub
{
    public class BloqueI : Bloque
    {
        private Posicion[][] Casillas = new Posicion[][]
        {
            new Posicion[] {new(1,0),new(1,1),new(1,2),new(1,3)},
            new Posicion[] {new(0,2),new(1,2),new(2,2),new(3,2)},
            new Posicion[] {new(2,0),new(2,1),new(2,2),new(2,3)},
            new Posicion[] {new(0,1),new(1,1),new(2,1),new(3,1)};
    }
}
}
