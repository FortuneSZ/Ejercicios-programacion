using System;

class Coche : Vehiculo
{
	public Coche(string mar, string mod, int cil, float pot, int rue)
	{
		marca = mar;
		modelo = mod;
		cilindrada = cil;
		potencia = pot;
		CantidadDeRuedas = rue;
	}
}