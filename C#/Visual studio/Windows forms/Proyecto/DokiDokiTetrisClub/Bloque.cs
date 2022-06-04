//Esta es la clase de los bloques y las distintas cosas que estos pueden hacer
using System.Collections.Generic;
namespace DokiDokiTetrisClub
{
    public abstract class Bloque
    {
        protected abstract Posicion[][] Casillas { get; }
        protected abstract Posicion DBInicial { get; }
        // DBInicial = DistanciaBordeInicial
        public abstract int Id { get; }

        private int FaseRotacion;
        private Posicion DistanciaBorde;

        public Bloque()
        {
            DistanciaBorde = new Posicion(DBInicial.Fila,
               DBInicial.Columna);
        }

        public IEnumerable<Posicion> PosicionCasillas()
        {
            foreach (Posicion p in Casillas[FaseRotacion])
            {
                yield return new Posicion(p.Fila + DistanciaBorde.Fila,
                    p.Columna + DistanciaBorde.Columna);
            }
        }

        public void RotarHorario()
        {
            FaseRotacion = (FaseRotacion + 1) % Casillas.Length;
        }

        public void RotarAntiHorario()
        {
            if (FaseRotacion == 0)
            {
                FaseRotacion = Casillas.Length - 1;
            }
            else
            {
                FaseRotacion--;
            }
        }

        public void Mover(int fila, int columna)
        {
            DistanciaBorde.Fila = fila;
            DistanciaBorde.Columna = columna;
        }

        public void Reset()
        {
            FaseRotacion = 0;
            DistanciaBorde.Fila = DBInicial.Fila;
            DistanciaBorde.Columna = DBInicial.Columna;
        }
    }
}
