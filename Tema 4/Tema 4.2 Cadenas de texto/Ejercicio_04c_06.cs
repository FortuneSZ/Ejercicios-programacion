/**/
using System;
class ejercicio
{	
	static void Main()
	{
		int contador=1;
		string palabraabuscar="";
		string[] palabras = new string [10];
			for (int i=0;i<palabras.Length;i++)
			{
				Console.WriteLine("escriba la {0} palabras",contador);	
				palabras[i] = Console.ReadLine();
				contador++;
			}
			Console.Clear();
			do
			{
				Console.WriteLine("Escribe el texto a buscar:");
				palabraabuscar = Console.ReadLine();
				if (palabraabuscar != "fin")
				{
					for (int i = 0; i < palabras.Length; i++)
					{
						if (palabras[i].Contains(palabraabuscar))
						{
							Console.WriteLine("Encontrado en posicion {0}",i+1);
						}
					}
				}
			}
			while (palabraabuscar != "fin");
	}
}
