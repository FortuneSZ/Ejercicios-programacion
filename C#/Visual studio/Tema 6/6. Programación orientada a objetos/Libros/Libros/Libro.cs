using System;

class Libro
{
	string autor;
	string titulo;
	string ubicacion;

	public Libro()
    {
		autor = "";
		titulo = "";
		ubicacion = "";
    }

	public Libro(string a, string t, string u)
    {
		autor = a;
		titulo = t;
		ubicacion = u;
    }
	public string GetAutor()
	{
		return autor;
	}

	public void SetAutor(string valor)
	{
		autor = valor;
	}

	public string GetTitulo()
	{
		return titulo;
	}

	public void SetTitulo(string valor)
	{
		titulo = valor;
	}

	public string GetUbicacion()
	{
		return ubicacion;
	}

	public void SetUbicacion(string valor)
	{
		ubicacion = valor;
	}
	public void MostrarInformacion()
    {
		Console.WriteLine("Autor: " + autor);
		Console.WriteLine("Título: " + titulo);
		Console.WriteLine("Ubicación: " + ubicacion);
		Console.WriteLine();

	}
}
