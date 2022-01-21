using System;

class Persona
{
	protected string nombre;

	public Persona()
    {
		nombre = "";
    }

	public Persona(string n)
    {
		nombre = n;
    }
	public string Nombre
    {
        get { return nombre; }
        set { nombre=value; }
    }
	/*public void SetNombre(string valor)
	{
		nombre = valor;
	}

	public string GetNombre()
	{
		return nombre;
	}*/

	public void Saludar()
	{
		Console.WriteLine("Hola, soy " + nombre);
	}
	public void Saludar(string texto)
    {
		Console.WriteLine(texto);
    }
}
