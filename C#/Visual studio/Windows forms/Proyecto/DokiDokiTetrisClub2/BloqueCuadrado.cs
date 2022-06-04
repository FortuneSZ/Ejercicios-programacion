//Clase del bloque con forma cuadrada
namespace DokiDokiTetrisClub2
{
    public class BloqueCuadrado : Bloque
    {
        private readonly Posicion[][] casillas = new Posicion[][]
       {
            new Posicion[] {new(0,0),new(0,1),new(1,0),new(1,1) }
       };

        public override int Id => 4;
        protected override Posicion DBInicial => new Posicion(0, 4);
        protected override Posicion[][] Casillas => casillas;
    }
}
