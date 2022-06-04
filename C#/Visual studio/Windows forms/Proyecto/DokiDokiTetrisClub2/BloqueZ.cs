//Clase del bloque con forma de Z
namespace DokiDokiTetrisClub2
{
    public class BloqueZ : Bloque
    {
        private readonly Posicion[][] casillas = new Posicion[][]
        {
            new Posicion[] {new(0,0),new(0,1),new(1,1),new(1,2) },
            new Posicion[] {new(0,2),new(1,1),new(1,2),new(2,1) },
            new Posicion[] {new(1,0),new(1,1),new(2,1),new(2,2) },
            new Posicion[] {new(0,1),new(1,0),new(1,1),new(2,0) }
        };

        public override int Id => 7;
        protected override Posicion DBInicial => new Posicion(0, 3);
        protected override Posicion[][] Casillas => casillas;
    }
}
