using System;

class Vehiculo
{
	protected string marca;
	protected string modelo;
	protected int cilindrada;
	protected float potencia;
	protected int CantidadDeRuedas;
	protected int velocidad;

	public Vehiculo()
	{
		marca = "";
		modelo = "";
		cilindrada = 0;
		potencia = 0;
		CantidadDeRuedas = 0;
		velocidad = 0;
	}
	public Vehiculo(string mar, string mod, int cil, float pot, int rue)
	{
		marca = mar;
		modelo = mod;
		cilindrada = cil;
		potencia = pot;
		CantidadDeRuedas = rue;
	}
	public string GetMarca()
	{
		return marca;
	}

	public void SetMarca(string valor)
	{
		marca = valor;
	}

	public string GetModelo()
	{
		return modelo;
	}

	public void SetModelo(string valor)
	{
		modelo = valor;
	}

	public int GetCilindrada()
	{
		return cilindrada;
	}

	public void SetCilindrada(int valor)
	{
		cilindrada = valor;
	}

	public float GetPotencia()
	{
		return potencia;
	}

	public void SetPotencia(float valor)
	{
		potencia = valor;
	}
	public int GetCantidadDeRuedas()
	{
		return CantidadDeRuedas;
	}

	public void SetCantidadDeRuedas(int valor)
	{
		CantidadDeRuedas = valor;
	}
	public void Circular()
    {
		velocidad = 50;
    }
	public void Circular(int vel)
    {
		velocidad = vel;
    }

	public void MostrarInformacion()
	{
		Console.WriteLine("Marca : {0}", marca);
		Console.WriteLine("Modelo : {0}", modelo);
		Console.WriteLine("Cilindrada : {0}", cilindrada);
		Console.WriteLine("Potencia : {0}", potencia);
		Console.WriteLine("Cantidad de ruedas : {0}", CantidadDeRuedas);
		Console.WriteLine();
	}
}