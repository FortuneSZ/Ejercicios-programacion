//Clase del bloque con forma de I
namespace DokiDokiTetrisClub2
{
    public class BloqueI : Bloque
    {
        private readonly Posicion[][] casillas = new Posicion[][]
        {
            new Posicion[] {new(1,0),new(1,1),new(1,2),new(1,3) },
            new Posicion[] {new(0,2),new(1,2),new(2,2),new(3,2) },
            new Posicion[] {new(2,0),new(2,1),new(2,2),new(2,3) },
            new Posicion[] {new(0,1),new(1,1),new(2,1),new(3,1) }
        };

        public override int Id => 1;
        protected override Posicion DBInicial => new Posicion(-1, 3);
        protected override Posicion[][] Casillas => casillas;
    }
}
