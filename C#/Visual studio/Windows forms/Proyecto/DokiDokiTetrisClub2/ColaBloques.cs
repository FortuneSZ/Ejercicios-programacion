using System;
namespace DokiDokiTetrisClub2
{
    public class ColaBloques
    {
        private Bloque[] Bloques = new Bloque[]
        {
            new BloqueI(),
            new BloqueCuadrado(),
            new BloqueJ(),
            new BloqueS(),
            new BloqueL(),
            new BloqueT(),
            new BloqueZ()
        };

        private Random random = new Random();

        public Bloque SiguienteBloque { get; private set; }

        public ColaBloques()
        {
            SiguienteBloque = BloqueRandom();
        }

        private Bloque BloqueRandom()
        {
            return Bloques[random.Next(Bloques.Length)];
        }

        public Bloque Actualizar()
        {
            Bloque bloque = SiguienteBloque;
            do
            {
                SiguienteBloque = BloqueRandom();
            }
            while (bloque.Id == SiguienteBloque.Id);

            return bloque;
        }
    }
}
