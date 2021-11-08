/**/
using System;
class ejercicio
{	
	static void Main()
	{
		string nombre;
		Console.WriteLine("escriba su nombre");
		nombre = Console.ReadLine();

		for(int i=0;i<=nombre.Length;i++)
		{
			Console.WriteLine(nombre.Substring(0,i));
		}
	}
}
