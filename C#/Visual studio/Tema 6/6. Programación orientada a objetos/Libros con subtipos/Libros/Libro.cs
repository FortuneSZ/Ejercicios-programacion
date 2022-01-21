using System;

class Libro : Documento
{
	public Libro()
	{
		autor = "";
		titulo = "";
		ubicacion = "";
	}
	private int numPaginas;
	public int GetNumPaginas()
	{
		return numPaginas;
	}

	public void SetNumPaginas(int valor)
	{
		numPaginas = valor;
	}
	public Libro(string autor, string titulo, string ubicacion, int numPaginas)
	{
		this.autor = autor;
		this.titulo = titulo;
		this.ubicacion = ubicacion;
		this.numPaginas = numPaginas;
	}
}
