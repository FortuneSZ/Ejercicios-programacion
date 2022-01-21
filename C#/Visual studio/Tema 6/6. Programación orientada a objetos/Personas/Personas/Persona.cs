using System;

class Persona
{
	private string nombre;

	public string Nombre
	{
		get
		{
			return nombre;
		}
		set
		{
			nombre = value;
		}

	}
	public Persona()
    {
		nombre = "";
    }
	public Persona(string n)
    {
		nombre = n;
    }
	public void Saludar()
	{
		Console.WriteLine("Hola, soy " + nombre);
	}
}
