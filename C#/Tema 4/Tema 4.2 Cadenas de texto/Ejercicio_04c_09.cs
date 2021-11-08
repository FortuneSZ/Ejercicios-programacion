/**/
using System;
class ejercicio
{	
	static void Main()
	{
		string texto;
		Console.WriteLine("escriba un texto");
		texto = Console.ReadLine();
		while(texto.Contains("  "))
		{
			texto=texto.Replace("  "," ");
		}
		Console.WriteLine("texto corregido");
		Console.WriteLine(texto);
	}
					
}
