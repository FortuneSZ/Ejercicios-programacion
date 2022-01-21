using System;

class Coche
{
	private string marca;
	private string modelo;
	private int cilindrada;
	private float potencia;

	public Coche()
	{
		marca = "";
		modelo = "";
		cilindrada = 0 ;
		potencia = 0 ;
	}

	public Coche(string m, string ma, int c, float p)
	{
		marca = m;
		modelo = ma;
		cilindrada = c;
		potencia = p;
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
}
