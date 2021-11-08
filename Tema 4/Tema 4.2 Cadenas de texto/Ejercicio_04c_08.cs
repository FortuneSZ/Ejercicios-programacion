/**/
using System;
class ejercicio
{	
	static void Main()
	{
		int contador=1;
		string[] palabras = new string [10];
		for (int i=0;i<palabras.Length;i++)
		{
			Console.WriteLine("escriba la {0} palabras",contador);	
			palabras[i] = Console.ReadLine();
			contador++;
		}
		Console.Clear();
		for (int i = 0; i < palabras.Length; i++)
		{
			palabras[i]=palabras[i].Replace("Java","CSharp");
				
		}
		for (int i=0;i<palabras.Length;i++)
		{
			Console.WriteLine(palabras[i]);
		}
		
	}
					
}
