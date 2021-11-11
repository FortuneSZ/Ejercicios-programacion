/**/
using System;
using System.Text;
class Ejercicio_04c_15
{	
	static void Main()
	{
		string frase;
		int contadorguines=0;
		Console.WriteLine("Escribe una frase");
		frase = Console.ReadLine();
		Console.Clear();
		foreach(char letra in frase)
		{
			contadorguines++;
		}
		string guiones = new String('-', contadorguines);
		Console.WriteLine(frase);
		Console.WriteLine(guiones);
	}
}

