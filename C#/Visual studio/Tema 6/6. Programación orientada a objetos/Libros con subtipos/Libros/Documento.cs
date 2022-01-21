using System;
class Documento
{
	protected string autor;
	protected string titulo;
	protected string ubicacion;
	public Documento()
	{
		autor = "";
		titulo = "";
		ubicacion = "";
	}
	public Documento(string a, string t, string u)
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
		Console.WriteLine("Titulo: " + titulo);
		Console.WriteLine("Ubicacion: " + ubicacion);
		Console.WriteLine();
	}
}
