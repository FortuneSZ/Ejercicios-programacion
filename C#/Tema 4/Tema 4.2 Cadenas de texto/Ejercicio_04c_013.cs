/**/
using System;
using System.Text;
class ejercicio
{	
	static void Main()
	{
		Console.WriteLine("introduzca una frase o palabra");
		StringBuilder cadena = new StringBuilder(Console.ReadLine());
		for (int i=0;i<cadena.Length;i++)
		{
			if (cadena[i] =='a' ||
				cadena[i] =='e' ||
				cadena[i] =='i' ||
				cadena[i] =='u' )
			{
				cadena[i] = 'o';
			}
			if (cadena[i] =='á' ||
				cadena[i] =='é' ||
				cadena[i] =='í' ||
				cadena[i] =='ú' )
			{
				cadena[i] = 'ó';
			}		
		}
		Console.WriteLine(cadena);
	
	}
}

