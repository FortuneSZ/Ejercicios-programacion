using System;


class Moto : Vehiculo
{
	public Moto(string mar, string mod, int cil, float pot, int rue)
	{
		marca = mar;
		modelo = mod;
		cilindrada = cil;
		potencia = pot;
		CantidadDeRuedas = rue;
	}
}